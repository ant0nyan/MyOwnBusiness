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
        DatabaseClass data = new DatabaseClass();
        string userName = string.Empty;
        string userPassword = string.Empty;
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
        {
            userName = loginTextBox.Text;
            userPassword = passwordTextBox.Text;
            AutorizationConnect(userName, userPassword);
        }    
        public void AutorizationConnect(string userName, string userPassword)
        {
            string checkData = $"SELECT Id,username,password FROM LoginTable WHERE username ='{userName}' AND password='{userPassword}'";

            SqlDataReader read = data.GetDataReader(checkData);           
            try
            {
                read.Read();
                if (read["Id"].ToString() == "1")
                {
                    ActiveForm.Hide();
                    AdminPanel frm1 = new AdminPanel();

                    frm1.Show();
                    data.CloseConnecttion();
                }
                else if (read["Id"].ToString() == "2")
                {

                    ActiveForm.Hide();
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
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                userName = loginTextBox.Text;
                userPassword = passwordTextBox.Text;
                AutorizationConnect(userName, userPassword);
            }
        }
    }
}
