using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{   
    public partial class Employer : Form
    {
        private int productCount;
        private int id = -1;
        int totalPrice = 0;

        DatabaseClass1 dataBase = new DatabaseClass1();

        List<int> rowIndex = new List<int>();
        List<DateTime> dateList= new List<DateTime>();
        List<int> priceList= new List<int>();
        public Employer()
        {
            InitializeComponent();
        }

        private void Employe_Load(object sender, EventArgs e)
        {
            refreshButtonEmployerPanel.Image = System.Drawing.Image.FromFile(@"C:\Users\User\Desktop\CoffeShop\Resourses\refresh.png");
            searchButtonEmployer.Image = System.Drawing.Image.FromFile(@"C:\Users\User\Desktop\CoffeShop\Resourses\search.png");
            string checkData = $"SELECT Id,Type,Name,Price FROM Product_Adder ";
            CreateColumns();
            RefreashDatGrid(employerDataGridView, checkData);
            UnVisibleFirstRow(employerDataGridView);
        }
        private void CreateColumns() //Syuneri sarqelu procesy
        {
            employerDataGridView.Columns.Add("Id", "Id");
            employerDataGridView.Columns.Add("Type", "Տեսակը");
            employerDataGridView.Columns.Add("Name", " Ապրանքի անունը");
            employerDataGridView.Columns.Add("Price", "Գինը");
            employerDataGridView.Columns[0].Visible = false;
        }
        private void ReadSingleRows(DataGridView dgw, IDataRecord record) // toxery avelacnelu procesy
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3));
        }
        private void RefreashDatGrid(DataGridView dgw, string checkData) // hramany katarelu u toxery lracnelu process
        {
            dgw.Rows.Clear();


            SqlCommand command = new SqlCommand(checkData, dataBase.getConnection());

            dataBase.OpenConnecttion();

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ReadSingleRows(dgw, dataReader);
                IngridForSale.idList.Add(dataReader.GetInt32(0));
                IngridForSale.typeList.Add(dataReader.GetString(1));
                IngridForSale.nameList.Add(dataReader.GetString(2));
                IngridForSale.priceList.Add(dataReader.GetInt32(3));


            }
            dataReader.Close();
            employerDataGridView.CurrentCell = null;
        }
        private void Search(DataGridView dgw)//searchi pahy
        {
            dgw.Rows.Clear();
            string searchCommand = $"SELECT * FROM Product_Adder WHERE CONCAT (Id,Type,Name,Price) LIKE N'%" + serachTextBoxEmployer.Text + "%'";

            SqlCommand command = new SqlCommand(searchCommand, dataBase.getConnection());

            dataBase.OpenConnecttion();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRows(dgw, read);
            }
            read.Close();

        }
        private void employerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)//toxery yntrelu pahy
        {

            id = e.RowIndex;
            FirstInformationCreate();
        }

        private void addButtonEmployer_Click(object sender, EventArgs e)
        {
            ClearLabels();
            productCount = Convert.ToInt32(countNumericUpDown.Value);
            if (id == -1 || productCount == 0)
            {
                MessageBox.Show("Error please Select product and Input count", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                addProductInformation();
                
                dateList.Add(Convert.ToDateTime(DateTime.Now));
            }
            
        }

        private void addProductInformation()
        {
            FirstInformationCreateWithRowIndex();

            
           int count = productCount;
           int price = Convert.ToInt32(firstPriceLabel.Text);

            AllInformationCreate();

            showTotal.Text = ShowTotalPrice(price, count).ToString();//yndhanur gumary
        }

        private int ShowTotalPrice(int price, int count)
        {
            priceList.Add(price * count);
            totalPrice += price * count;
            return totalPrice;

        }
        public void ClearLabels()
        {
            employerTypeLabel.Text = "";
            employerNameLabel.Text = "";
            employerPriceLabel.Text = "";
            employerCountLabel.Text = "";

        }

        private void FirstInformationCreate ()//arajnayin informaciayi stexcumy
        {
            DataGridViewRow row = employerDataGridView.Rows[id];
            firstTypeLabel.Text = $"{row.Cells[1].Value}";
            firstNameLabel.Text = $"{row.Cells[2].Value}";
            firstPriceLabel.Text = $"{Convert.ToInt32(row.Cells[3].Value)}";
          
        }
        private void FirstInformationCreateWithRowIndex()//arajnayin informaciayi stexcumy u row indexi mej avelacumy
        {
            DataGridViewRow row = employerDataGridView.Rows[id];

            rowIndex.Add(Convert.ToInt32(row.Cells[0].Value));
        }

        private void AllInformationCreate() // cheki masy
        {                   
                IngridForSale.countList.Add(productCount);
                for (int i = 0; i < IngridForSale.idList.Count; i++)
                {
                    for (int j = 0; j < rowIndex.Count; j++)
                    {
                        if (rowIndex[j] == IngridForSale.idList[i])
                        {
                            employerTypeLabel.Text += $"{IngridForSale.typeList[i]}\n";
                            employerNameLabel.Text += $"{IngridForSale.nameList[i]}\n";
                            employerPriceLabel.Text += $"{IngridForSale.priceList[i]}\n";
                            employerCountLabel.Text += $"{IngridForSale.countList[j]}\n";
                        }
                    }
                }            
        }
        public void UnVisibleFirstRow(DataGridView dataGridView1)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells[1].Value.ToString().ToLower().Contains("111111"))
                {
                    dr.Visible = false;
                }
            }
        }//1 toxy unvisiblya sarqum
        private void SendIdAndCountToBase(List<int> id ,List<int> count,List<DateTime> dates,List<int> price)//vajarvac apranqneri tvyalnery uxarkuma baza
        {   
            string command;
            for (int i = 0; i < id.Count; i++)
            {
                string z = DatabaseClass1.DateTimeFormat(dates[i]);
                command = $"INSERT INTO SalesProducts (IdSaleProduct,CountSaleProduct,TimeSaleProduct,PriceSalesProduct)VALUES ('{id[i]}','{count[i]}','{z}','{price[i]}')";
                dataBase.SendCommand(command);
            }
        }
        private void CompareIdAndProdJoinTableId(List<int> id) //Compare With Ingrid_JoinProduct and take dates to 2 list
        {
            SqlDataReader data;
            for (int i = 0; i < id.Count; i++)
            {
                string command = $"SELECT PIid,PICount FROM Ingrid_JoinProduct WHERE Pid='{id[i]}'";
               data= dataBase.GetDataReader(command);
                while (data.Read())
                {
                    DeleteVandakanishFromDate(data[0].ToString(),IngridForSale.idListToSendBase);
                    DeleteVandakanishFromDate(data[1].ToString(), IngridForSale.countListToSendBase);

                }
                data.Close();
            }
        }
        private void saveButtonEmployer_Click(object sender, EventArgs e)
        {
            if (id==-1)
            {
                MessageBox.Show("Please add Products and then click save","Invalid Operation",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                SendIdAndCountToBase(rowIndex, IngridForSale.countList, dateList,priceList);
                CompareIdAndProdJoinTableId(rowIndex);
                FindMinusCount(IngridForSale.countList, IngridForSale.countListToSendBase);
                MinusIngridInBase();
                ClearAllInformation();
            }
            
           
        }

        private void FindMinusCount(List<int> countProduct,List<int> countIngrid)// hanvox ingrid qanakna gtnum qcum listi mej
        {
            for (int i = 0; i < countProduct.Count; i++)
            {
                for (int j = 0; j < countIngrid.Count; j++)
                {
                    IngridForSale.countListToSendBase[j] = countIngrid[j] * countProduct[i]; 
                }

            }
        }
        private void DeleteVandakanishFromDate(string id,List<int> list) // VANDAKANISHNERY JNJUMA TVERA SARQUM ARANDZIN U QCUM LISTI MEJ
        {
           
            string number = string.Empty;
            int index = 0;
            int index2 = 0;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == '#')
                {
                    index = i;
                    for (int j = index2; j < index; j++)
                    {
                        number += id[j];
                    }
                    index2 = i + 1;

                    list.Add( Convert.ToInt32(number));
                    
                    number = " ";

                }
            }
        }

        private void MinusIngridInBase() // bazayi mejic hanuma ingridneri qanaky
        {
            for (int i = 0; i < IngridForSale.idListToSendBase.Count; i++)
            {

                string command = $"UPDATE ProductIngridients SET  Count = Count - {IngridForSale.countListToSendBase[i]}" +
                    $" WHERE Id = {IngridForSale.idListToSendBase[i]}";

                dataBase.SendCommand(command);
            }
        }

        private void ClearAllInformation()
        {
            IngridForSale.countList.Clear();
            IngridForSale.countListToSendBase.Clear();
            IngridForSale.idListToSendBase.Clear();
            rowIndex.Clear();
            ClearLabels();
            totalPrice = 0;
            id = -1;
            productCount = 0;
            dateList.Clear();
            countNumericUpDown.ResetText();
            showTotal.Text = "";
            firstTypeLabel.Text = $" ";
            firstNameLabel.Text = $" ";
            firstPriceLabel.Text = $" ";
           
        }//0 acnuma sax

        private void Employe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ClearAllInformation();
        }

        private void serachTextBoxEmployer_TextChanged(object sender, EventArgs e)
        {
            Search(employerDataGridView);
            AdminPanel.UnVisibleFirstRow(employerDataGridView);
        }
    }
}
