using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace CoffeShop
{
    public partial class AdminPanel
    {
        private void CreateColumnsWriteOut() //Syuneri sarqelu procesy
        {
            dataGridView3.Columns.Add("Id", "ID");
            dataGridView3.Columns.Add("Name", " Ապրանքի անունը");
            dataGridView3.Columns.Add("Count", "Քանակ");
            dataGridView3.Columns.Add("Date", "Ամսաթիվ");
        }
        private void ReadSingleRowsWriteOut(DataGridView dgw, IDataRecord record) // toxery avelacnelu procesy
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetDateTime(3));
        }
        private void RefreashDatGridWriteOut(DataGridView dgw, string checkData) // hramany katarelu u toxery lracnelu process
        {
            dgw.Rows.Clear();

            SqlCommand command = new SqlCommand(checkData, dataBase.getConnection());

            dataBase.OpenConnecttion();

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ReadSingleRowsWriteOut(dgw, dataReader);
            }
            dataReader.Close();
        }
        private void productListBoxAdder() //writing outi list boxi avelacnely
        {
            SqlDataReader dataReader = dataBase.GetDataReader(checkDataFood);

            while (dataReader.Read())
            {
                productListBox.Items.Add(dataReader[2].ToString());
            }
            dataReader.Close();

        }
        private void CountWritingOutBase(string nameProduct, int count)
        {
            string updateCommand = $"Update ProductIngridients Set Count = Count - '{count}' Where Name = N'{nameProduct}'";
            string insertCommand = $"INSERT INTO WriteOut (Name,Count,Date)VALUES (N'{nameProduct}','{count}','{DatabaseClass.DateTimeFormat(DateTime.Now)}')";

            dataBase.SendCommand(updateCommand);
            dataBase.SendCommand(insertCommand);


        }
        private void writingOut_Click(object sender, EventArgs e)
        {
            CountWriteOut();
        }
        private void CountWriteOut()
        {
            string prodName = productListBox.GetItemText(productListBox.SelectedItem);
            int count;
            if (prodName != null && int.TryParse(ingridCountTextBox.Text, out count))
            {
                CountWritingOutBase(prodName, count);
                MessageBox.Show($"The {prodName} writed out successfully!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreashDatGridFood(dataGridView2, checkDataFood);

            }
            else
            {
                MessageBox.Show("Error please Input count and select product", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void FindByDate()
        {
            dataGridView3.Rows.Clear();
            string start = DatabaseClass.DateTimeFormat( dateTimePicker3.Value);
            string end = DatabaseClass.DateTimeFormat(dateTimePicker4.Value);
            string checkDate = $"SELECT * FROM WriteOut WHERE Date >= '{start}' AND Date < '{end}'";
            SqlDataReader reader = dataBase.GetDataReader(checkDate);
            while (reader.Read())
            {   
                ReadSingleRowsWriteOut(dataGridView3,reader);
                
            }
            dataBase.CloseConnecttion();
            

        }
        private void searchWritingOutButton_Click(object sender, EventArgs e)
        {
            FindByDate();
        }
    }
}
