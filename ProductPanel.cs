using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;

namespace CoffeShop
{
    public partial class AdminPanel : Form
    {
        bool hasFlag = false;
        bool hasFlagProfit = false;
        bool hasFlagCount = false;
        public static  DateTime time = new DateTime();
        public List<string> colorMCFN = new List<string>();
        private void foodAddButton_Click(object sender, EventArgs e)
        {
            string productType = foodTypeTextBox.Text;
            string productName = foodNameTextBox.Text;
            int productCount;
            int productPrice;
            int productMCFN;
            CheckDate(productName);
            if (int.TryParse(foodPriceTextBox.Text, out productPrice) &&
                int.TryParse(foodCountTextBox.Text, out productCount) && 
                int.TryParse(mcfnTextBox.Text, out productMCFN) &&
                hasFlagCount == true)
            {
                if (hasFlag == false)
                {
                    time = DateTime.Now;
                    ProductIngridients.AddProduct(productType, productName, productCount, productPrice, time,pieceOrGram,productMCFN);
                    hasFlag = true;

                }
                else
                {
                    UpdateCountAndPrice(productPrice, productCount, productName);
                }
                hasFlagCount = false;
            }
            else
            {
                MessageBox.Show("The inpuded datas are in the wrong format", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }
        private void foodDeleteButton_Click(object sender, EventArgs e)
        {

            if (dataGridView2.CurrentCell == null)
            {
                MessageBox.Show("Choose the row", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = dataGridView2.CurrentCell.RowIndex;
                DeleteRows(dataGridView2, index, 0, 3);
                CleareTextBoxesFood();

            }
        }
        private void CleareTextBoxesFood()///text boxer y maqrelu hamar
        {
            foodTypeTextBox.Text = "";
            foodNameTextBox.Text = "";
            foodCountTextBox.Text = "";
            foodPriceTextBox.Text = "";
            mcfnTextBox.Text = "";
            pieceButton.FillColor = Color.FromArgb(94, 148, 255);
            gramButton.FillColor = Color.FromArgb(94, 148, 255);
        }
        private void foodSaveButton_Click(object sender, EventArgs e)
        {
            UpdateDataBaseFood();

            UpdateDataBaseDeleted(dataGridView2, "ProductIngridients");
            CleareTextBoxesFood();
        }
        private void CreateColumnsFood() //Syuneri sarqelu procesy
        {
            dataGridView2.Columns.Add("Id", "ID");
            dataGridView2.Columns.Add("Type", "Տեսակը");
            dataGridView2.Columns.Add("Name", "Ապրանքի անունը");
            dataGridView2.Columns.Add("Count", "Քանակ");
            dataGridView2.Columns.Add("MCFN", "MCFN");

            dataGridView2.Columns.Add("IsNew", string.Empty);
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[5].Visible = false;
        }

        private void ReadSingleRowsFood(DataGridView dgw, IDataRecord record) // toxery avelacnelu procesy
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4),  RowState.ModifiedNew);
        }

        private void RefreashDatGridFood(DataGridView dgw, string checkData) // hramany katarelu u toxery lracnelu process
        {
            dgw.Rows.Clear();

            CheckMCFNFromBase();
            SqlCommand command = new SqlCommand(checkData, dataBase.getConnection());

            dataBase.OpenConnecttion();

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ReadSingleRowsFood(dgw, dataReader);
            }
           
            dataReader.Close();
            ChangeRowColorByMCFN();
        }

        private void refreshButtonFoodPanel_Click(object sender, EventArgs e)
        {
            string checkData = $"SELECT Id,Type,Name,Count,MCFN FROM ProductIngridients ";
            RefreashDatGridFood(dataGridView2, checkData);
            CleareTextBoxesFood();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowFood = e.RowIndex; // toxery buttoni mej dnelu processy
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRowFood];

                foodTypeTextBox.Text = row.Cells[1].Value.ToString();
                foodNameTextBox.Text = row.Cells[2].Value.ToString();
                foodCountTextBox.Text = row.Cells[3].Value.ToString();
                mcfnTextBox.Text = row.Cells[4].Value.ToString();


            }

        }

        private void SearchFood(DataGridView dgw)//searchi pahy
        {
            dgw.Rows.Clear();
            string searchCommand = $"SELECT * FROM ProductIngridients WHERE CONCAT (Type,Name,Count) LIKE N'%" + serachTextBoxFood.Text + "%'";

            SqlCommand command = new SqlCommand(searchCommand, dataBase.getConnection());

            dataBase.OpenConnecttion();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowsFood(dgw, read);
            }
            read.Close();
        }
        private void serachTextBoxFood_TextChanged(object sender, EventArgs e)
        {
            SearchFood(dataGridView2);
        }
        private void ChangeDateFood()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
            var type = foodTypeTextBox.Text;
            var name = foodNameTextBox.Text;
            int mcfn;
            int count;
            int id = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells[0].Value);

            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {

                if (int.TryParse(foodCountTextBox.Text, out count) && 
                    int.TryParse(mcfnTextBox.Text, out mcfn))
                {
                    dataGridView2.Rows[selectedRowIndex].SetValues(id, type, name, count,mcfn);
                    dataGridView2.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                    MessageBox.Show("Please Input number", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void foodEditButton_Click(object sender, EventArgs e)
        {
            ChangeDateFood();
            CleareTextBoxesFood();
        }
        private void UpdateDataBaseFood()//Updati pahy ogtagorcvuma savi vaxt
        {
            dataBase.OpenConnecttion();

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView2.Rows[i].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    var type = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    var name = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    var count = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    var mcfn = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    var changeDate = $"UPDATE ProductIngridients SET Type= N'{type}',Name= N'{name}',Count= N'{count}',MCFN='{mcfn}' WHERE Id='{id}'";

                    dataBase.SendCommand(changeDate);
                }
            }
            dataBase.CloseConnecttion();
        }
        private void addIngridButton_Click(object sender, EventArgs e)
        {
            Ingridients_Form frm = new Ingridients_Form();
            frm.Show();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Application.Exit();

        }
        private void DeletePidFromIngrid_JoinProduct(int id)
        {
            var deleteRow = $"DELETE FROM Ingrid_JoinProduct WHERE Pid ={id}";
            dataBase.SendCommand(deleteRow);
        }
        private void CheckDate(string productName)
        {
            dataBase.OpenConnecttion();
            string command = $"SELECT COUNT(Name)  FROM ProductIngridients WHERE  Name=N'{productName}'";
            SqlConnection connect = dataBase.getConnection(); ;
            SqlCommand comm = new SqlCommand(command, connect);
            int count = (Int32)comm.ExecuteScalar();
            if (count>0)
            {
                hasFlag = true;
            }
            else
            {
                hasFlag = false;
            }
            dataBase.CloseConnecttion();
        }
        private void UpdateCountAndPrice(int productPrice,int productCount,string productName)//???
        {
            DialogResult dialogResult = MessageBox.Show("This product has in base ,you want to add count and price?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var changeDate = $"UPDATE ProductIngridients SET Count = Count + {productCount} WHERE Name= N'{productName}'";
                dataBase.SendCommand(changeDate);
                //time = DateTime.Now;
                var changeDate2 = $"INSERT INTO ProductBuyingPrice (Name,Price,Date) VALUES   (N'{productName}','{productPrice}','{dateNow}')";
                dataBase.SendCommand(changeDate2);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("This product has in base!!! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                      
        }
        private void pieceButton_Click(object sender, EventArgs e)
        {
                hasFlagCount = true;
                pieceOrGram = 0;
                gramButton.FillColor = Color.FromArgb(94, 148, 255);
                pieceButton.FillColor = Color.FromArgb(0, 192, 0);
        }

        private void gramButton_Click(object sender, EventArgs e)
        {
            hasFlagCount = true;
            gramButton.FillColor = Color.FromArgb(0, 192, 0);       
            pieceOrGram = 1;
            pieceButton.FillColor = Color.FromArgb(94, 148, 255);
        }

        private void mcfnLabel_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Minimum count for Notification", mcfnLabel);
        }
        private void CheckMCFNFromBase()
        {
            string command = $"SELECT Name FROM ProductIngridients WHERE MCFN>Count";
            
            

            SqlDataReader read = dataBase.GetDataReader(command);                       

            while (read.Read())
            {
                colorMCFN.Add(read.GetString(0));
            }
            read.Close();

        }
        private void ChangeRowColorByMCFN()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                for (int i = 0; i < colorMCFN.Count; i++)
                {
                    if (row.Cells[2].Value.ToString() == colorMCFN[i])
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            colorMCFN.Clear();
        }
    }
}
