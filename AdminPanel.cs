﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using System.Xml.Linq;

namespace CoffeShop
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,

    }
    public partial class AdminPanel : Form
    {
        DatabaseClass dataBase = new DatabaseClass();

        int selectidRow;
        int selectedRowFood;

        private void CreateColumns() //Syuneri sarqelu procesy
        {
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Type", "Տեսակը");
            dataGridView1.Columns.Add("Name", " Ապրանքի անունը");
            dataGridView1.Columns.Add("Price", "Գինը");
            dataGridView1.Columns.Add("IsNew", string.Empty);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
        private void ReadSingleRows(DataGridView dgw, IDataRecord record) // toxery avelacnelu procesy
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), RowState.ModifiedNew); dataGridView1.CurrentCell = null;

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
            }
            dataReader.Close();
            dataGridView1.CurrentCell = null;

        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            //this.productIngridientsTableAdapter.Fill(this.database1DataSet.ProductIngridients);
            refreshButton.Image = System.Drawing.Image.FromFile(@"C:\Users\User\Desktop\CoffeShop\Resourses\refresh.png");
            refreshButtonFoodPanel.Image = System.Drawing.Image.FromFile(@"C:\Users\User\Desktop\CoffeShop\Resourses\refresh.png");
            searchButtonFood.Image = System.Drawing.Image.FromFile(@"C:\Users\User\Desktop\CoffeShop\Resourses\search.png");
            searchButton.Image = System.Drawing.Image.FromFile(@"C:\Users\User\Desktop\CoffeShop\Resourses\search.png");
            string checkData = $"SELECT Id,Type,Name,Price FROM Product_Adder ";
            string checkDataFood = $"SELECT Id,Type,Name,Count FROM ProductIngridients ";
            CreateColumns();
            CreateColumnsFood();
            RefreashDatGrid(dataGridView1, checkData);
            RefreashDatGridFood(dataGridView2, checkDataFood);
            UnVisibleFirstRow(dataGridView1);
            DayProfit();//day profit tablum tvyalneri avelacum hetaga live charti hamar
            LiveChartsConnectWithBase();
            sellingLabel.Text = " ";
            buyingLabel.Text = " ";
            profitLabel.Text = " ";        }
        public AdminPanel()
        {
            InitializeComponent();
        }

        static public void UnVisibleFirstRow(DataGridView dataGridView1)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells[1].Value.ToString().ToLower().Contains("111111"))
                {
                    dr.Visible = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectidRow = e.RowIndex; // toxery buttoni mej dnelu processy
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectidRow];

                TypeTextBox.Text = row.Cells[1].Value.ToString();
                NameTextBox.Text = row.Cells[2].Value.ToString();
                priceTextBox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string checkData = $"SELECT Id,Type,Name,Price FROM Product_Adder ";
            RefreashDatGrid(dataGridView1, checkData);
            CleareTextBoxes();
            UnVisibleFirstRow(dataGridView1);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //apranq avelacnelu pahy

            var type = TypeTextBox.Text;
            var name = NameTextBox.Text;
            int autoId;
            int price;
            string addLastId = "SELECT MAX(Id) FROM Product_Adder";
            string addMaxId = "SELECT MAX(Id) FROM Ingrid_JoinProduct";
            int id = dataBase.GetLastId(addLastId); // product adderi verji idin
            if (Ingridients_Form.flagAdder == true)
            {
               
                if (int.TryParse(priceTextBox.Text, out price)) // verji idnery qtnum enq u 
                {
                    var addDate = $"INSERT INTO Product_Adder (Id,Type,Name,Price)VALUES ('{id}',N'{type}',N'{name}',N'{price}')";
                    dataBase.SendCommand(addDate);

                    autoId = dataBase.GetLastId(addMaxId); //Ingridi meji verji idin
                    dataBase.InsertPid(id, autoId - 1);
                    ClearListDates(IngridForSale.nameListForLabel, IngridForSale.countListToSendBase, IngridForSale.idListToSendBase);

                    MessageBox.Show($"The  product  added successfully!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please Input valid dates", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please add ingredients", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Search(DataGridView dgw)//searchi pahy
        {
            dgw.Rows.Clear();
            string searchCommand = $"SELECT * FROM Product_Adder WHERE CONCAT (Id,Type,Name,Price) LIKE N'%" + searchTextBox.Text + "%'";

            SqlCommand command = new SqlCommand(searchCommand, dataBase.getConnection());

            dataBase.OpenConnecttion();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRows(dgw, read);  
            }
            read.Close();

        }

        private void UpdateDataBase()//Updati pahy ogtagorcvuma savi vaxt
        {
            dataBase.OpenConnecttion();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    var price = dataGridView1.Rows[i].Cells[3].Value.ToString();

                    var changeDate = $"UPDATE Product_Adder SET Type= N'{type}',Name= N'{name}',Price= N'{price}' WHERE Id='{id}'";

                    dataBase.SendCommand(changeDate);
                }
            }
            dataBase.CloseConnecttion();
        }
        private void DeleteRows(DataGridView gridView, int index, int indexForStart, int indexForEnd)//toxery jnjely
        {
            gridView.Rows[index].Visible = false;
            if (gridView.Rows[index].Cells[indexForStart].Value.ToString() == string.Empty)
            {
                gridView.Rows[index].Cells[indexForEnd].Value = RowState.Deleted;
                return;
            }
            gridView.Rows[index].Cells[indexForEnd].Value = RowState.Deleted;
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
            UnVisibleFirstRow(dataGridView1);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Choose the row", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                DeleteRows(dataGridView1, index, 0, 3);
                CleareTextBoxes();
            }
        }
        private void UpdateDataBaseDeleted(DataGridView dataGrid, string tableName)//Updati pahy ogtagorcvuma ????? problem deleti vaxt dra hamar nuynatipi 2 funkcia
        {
            dataBase.OpenConnecttion();

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                var rowState = (RowState)dataGrid.Rows[i].Cells[3].Value;

                if (rowState == RowState.Existed)
                    continue;


                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGrid.Rows[i].Cells[0].Value);

                    var deleteRow = $"DELETE FROM {tableName} WHERE Id ={id}";
                    DeletePidFromIngrid_JoinProduct(id);

                    dataBase.SendCommand(deleteRow);
                }
            }
            dataBase.CloseConnecttion();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            UpdateDataBaseDeleted(dataGridView1, "Product_Adder");
            UpdateDataBase();
            CleareTextBoxes();
        }

        private void ChangeDate()
        {


            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Choose the row", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                var type = TypeTextBox.Text;
                var name = NameTextBox.Text;
                int price;
                int id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
                if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {

                    if (int.TryParse(priceTextBox.Text, out price))
                    {
                        dataGridView1.Rows[selectedRowIndex].SetValues(id, type, name, price);
                        dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                        dataGridView1.CurrentCell = null;

                    }
                    else
                        MessageBox.Show("Choose the row and input changing dates", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            ChangeDate();
            CleareTextBoxes();
        }
        private void CleareTextBoxes()///text boxer y maqrelu hamar
        {
            TypeTextBox.Text = "";
            NameTextBox.Text = "";
            priceTextBox.Text = "";
        }
        public void ClearListDates(List<string> nameList, List<int> countList, List<int> idList)
        {
            nameList.Clear();
            countList.Clear();
            idList.Clear();
        }

        

        
    }
}  

    
  
  