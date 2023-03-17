using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Security.Cryptography.X509Certificates;

namespace CoffeShop
{
    public class DatabaseClass1
    {
        private SqlConnection sqlConnect = null;
        static int lastId;
        public DatabaseClass1()
        {
            sqlConnect = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            sqlConnect.Open();  
        }
        public void OpenConnecttion()
        {
            if (sqlConnect.State==System.Data.ConnectionState.Closed)
            {
                sqlConnect.Open();
            }
        }

        public void CloseConnecttion()
        {
            if (sqlConnect.State == System.Data.ConnectionState.Open)
            {
                sqlConnect.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnect;
        }
        
        public void SendCommand(string addDate)
        {
            OpenConnecttion();
            var command = new SqlCommand(addDate, getConnection());
            command.ExecuteNonQuery();
            CloseConnecttion();
        }
        public SqlDataReader GetDataReader(string searchCommand)
        {
            SqlCommand command = new SqlCommand(searchCommand, getConnection());

            OpenConnecttion();

            SqlDataReader read = command.ExecuteReader();

            return read;
        }
        public int GetLastId(string addDate) //  Producd_id /// bazayi mejic verjin  idin berely
        {    
            OpenConnecttion();

            var command = new SqlCommand(addDate, getConnection());
            command.ExecuteNonQuery();
            lastId = Convert.ToInt32(command.ExecuteScalar());

            if (lastId==0)
            {
                CloseConnecttion();
                return 1;
            }
            else
            {
                lastId++;
                CloseConnecttion();
                return lastId;
            }   
        }
        public void InsertPid(int id,int autoId)
        {
           string addPIdToBase = $"update Ingrid_JoinProduct set Pid='{id}' WHERE Id='{autoId}'";
           SendCommand(addPIdToBase);
        }
        static public string DateTimeFormat(DateTime dates)
        {
            return Convert.ToDateTime(dates).ToString("MM-dd-yyyy HH:mm:ss");
        }

        public int ReturnTotal(string command)
        {
            int total;
            OpenConnecttion();
            SqlCommand sqlComm = new SqlCommand(command, getConnection());
            if (Int32.TryParse(sqlComm.ExecuteScalar().ToString(),out total))
            {
                CloseConnecttion();
                return total;
            }
            else
            {
                CloseConnecttion();
                return 0;
            }    
        }

    }

    static public class IngridForSale
    {
        static private int id = -1;
       // static private int count = 0;

        static public List<int> idList = new List<int>();
        static public List<string> nameList = new List<string>();

        static public List<string> typeList = new List<string>();
        static public List<string> nameListForLabel = new List<string>();
        static public List<int>    priceList = new List<int>();
        static public List<int> countList = new List<int>();

        static public List<int> idListToSendBase = new List<int>();
        static public List<int> countListToSendBase = new List<int>();

        static public void AddProduct(int prodId,string prodName)
        {

            idList.Add(prodId);
            nameList.Add(prodName);

        }

        static public void AddId(int prodId)
        {
            idListToSendBase.Add(prodId);
        }

        static public void AddCount(int prodCount)
        {
            countListToSendBase.Add(prodCount);
        }

        static public void AddNameForLabel(string prodName)
        {
            nameListForLabel.Add(prodName);
        }

        static public void AddPriceForLabel(int prodPrice)
        {
            priceList.Add(prodPrice);
        }
        static public void AddTypeForLabel(string prodType)
        {
            typeList.Add(prodType);
        }

        static public string listToStringFormat(List<int> dates) //listy sarquma string format + #
        {
            string allDatesByString = string.Empty;
            for (int i = 0; i < dates.Count; i++)
            {
                allDatesByString += dates[i].ToString() + "#";
            }
            return allDatesByString;
        }



    }
}
