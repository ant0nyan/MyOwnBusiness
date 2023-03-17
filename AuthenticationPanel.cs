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
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace CoffeShop
{
    public partial class AuthenticationPanel : Form
    {
        public AuthenticationPanel()
        {
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;



        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
            loginLable.BackColor = Color.Transparent;
            passwordLabel.BackColor= Color.Transparent;

            passwordTextBox.PasswordChar = '*';
            loginTextBox.MaxLength = 50;
            passwordTextBox.MaxLength = 50;
            
        }
        private void enterButton_Click(object sender, EventArgs e)
        { string userName = loginTextBox.Text;
          string userPassword = passwordTextBox.Text;
            
            CoffeShopSqlConnect CoffeSql = new CoffeShopSqlConnect();
            CoffeSql.AutorizationConnect(userName, userPassword);
            

        }
    }
    public class CoffeShopSqlConnect :AuthenticationPanel
    {
        DatabaseClass data = new DatabaseClass();
        public SqlDataReader SqlRead(string queryString)
        {
           
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand sqlcommand = new SqlCommand(queryString, data.getConnection());
            SqlDataReader read = null;
            adapter.SelectCommand = sqlcommand;

            read = sqlcommand.ExecuteReader();
            return read;

        }
        public void AutorizationConnect(string userName,string userPassword)
        {
            string checkData = $"SELECT Id,username,password FROM LoginTable WHERE username ='{userName}' AND password='{userPassword}'";

            SqlDataReader read =SqlRead(checkData);

            this.Close();
            try
            {
                read.Read();
                if (read["Id"].ToString() == "1")
                {
                    AuthenticationPanel.ActiveForm.Hide();
                    AdminPanel frm1 = new AdminPanel();

                    frm1.Show();
                    data.CloseConnecttion(); 
                }
                else if (read["Id"].ToString() == "2")
                {

                    AuthenticationPanel.ActiveForm.Hide();
                    Employer Employe = new Employer();
                    Employe.Show();
                    data.CloseConnecttion();            
                }
            }
            catch
            {
                MessageBox.Show("The login or password are wrong");
                read.Close();
            }
        }
    }
}
