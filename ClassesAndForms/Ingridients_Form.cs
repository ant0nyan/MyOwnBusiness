using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace CoffeShop
{
      public partial class Ingridients_Form : Form
      { 
        DatabaseClass data = new DatabaseClass();        
        static public bool flagAdder = false;
        public Ingridients_Form()
        {
            InitializeComponent();
            IngridAdder();      
        }
        private void IngridAdder() // avelacnuma listi mej
        {
            DatabaseClass data = new DatabaseClass();
            
            string command = $" SELECT Id,Name,Count FROM ProductIngridients";//Ingridients_Form-i listi mej avelacnu pahy

            SqlDataReader read;
            read = data.GetDataReader(command);
            while (read.Read())
            {
                ingridListBox.Items.Add(read[1].ToString());

                IngridForSale.AddProduct(
                Convert.ToInt32(read[0].ToString()), read[1].ToString());
            }
            data.CloseConnecttion();
        }
        private int GetIdFromListName(string textForKnow) // stuguma name het tali idin
        {
            int k = -1;
            for (int i = 0; i < IngridForSale.nameList.Count; i++)
            {
                if (textForKnow == IngridForSale.nameList[i])
                {
                    k= IngridForSale.idList[i];
                }                    
            }
            return k;
        }
        private void addIngridCountButton_Click(object sender, EventArgs e)
        {
            GetProductCountAndId();
           
            flagAdder = true;        
        }  
        private void GetProductCountAndId() //avelacnuma listeri mej
        {
            int prodCount;
            
            int id;
            string ingridListBoxItem = ingridListBox.GetItemText(ingridListBox.SelectedItem);
            if (int.TryParse(ingridCountTextBox.Text, out prodCount) &&
                ingridCountTextBox.Text != "0" &&
                ingridListBox.GetItemText(ingridListBox.SelectedItem) != "")
            {
                id = GetIdFromListName(ingridListBoxItem);
                IngridForSale.AddId(id);

                prodCount = Convert.ToInt32(ingridCountTextBox.Text);
                IngridForSale.AddCount(prodCount);

                IngridForSale.AddNameForLabel(ingridListBoxItem);

                ShowAllIngridetsToLabel(IngridForSale.nameListForLabel,IngridForSale.countListToSendBase);
                MessageBox.Show($"The {ingridListBox.SelectedItem} accessed successfully!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error please Input count and select product", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendProductIdAndCountToBase(string prodId,string prodCount)
        {
            string addIdAndCount = $"INSERT INTO Ingrid_JoinProduct (PIid,PICount) VALUES ('{prodId}','{prodCount}')";
            data.SendCommand(addIdAndCount);
        }
        public void AllDatesToString()
        {
            string id = string.Empty;
            string count = string.Empty;
            count = IngridForSale.listToStringFormat(IngridForSale.countListToSendBase);
            id = IngridForSale.listToStringFormat(IngridForSale.idListToSendBase);

            if (id==string.Empty || count == string.Empty)
            {
                MessageBox.Show("Error please Input count and select product", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SendProductIdAndCountToBase(id, count);
                this.Close();
            }        
        }        
        public void ShowAllIngridetsToLabel(List<string> nameOfIngrid, List<int> countOfIngrid)
        {
            showAllIngrid.Text = "";

            for (int i = 0; i < nameOfIngrid.Count; i++)
            {
                showAllIngrid.Text += $"{nameOfIngrid[i]} - {countOfIngrid[i]} \n";
            }
        }
        private void editingIngridCountAndName_Click(object sender, EventArgs e)
        {
            EditingIngritDates();
        }
        public void EditingIngritDates()
        {
            if (IngridForSale.nameListForLabel.Count == 0)
            {
                MessageBox.Show("Adding Ingrithents for editing not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nameOfIngrid = ingridListBox.GetItemText(ingridListBox.SelectedItem);
                int newCount;
                for (int i = 0; i < IngridForSale.nameListForLabel.Count; i++)
                {
                    if (nameOfIngrid == IngridForSale.nameListForLabel[i] && int.TryParse(ingridCountTextBox.Text, out newCount))
                    {
                        IngridForSale.countListToSendBase[i] = Convert.ToInt32(ingridCountTextBox.Text);
                        MessageBox.Show($"The {ingridListBox.SelectedItem.ToString()} edited successfully!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (!int.TryParse(ingridCountTextBox.Text, out newCount))
                    {
                        MessageBox.Show("Please Input number", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ShowAllIngridetsToLabel(IngridForSale.nameListForLabel, IngridForSale.countListToSendBase);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            flagAdder = true;
            
            AllDatesToString();
            
        }
        private void Ingridients_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminPanel frm = new AdminPanel();
            frm.ClearListDates(IngridForSale.nameListForLabel, IngridForSale.countListToSendBase, IngridForSale.idListToSendBase);
        }
    } 
}
