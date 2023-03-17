using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace CoffeShop
{   
    public class ProductIngridients
    {
        static int id = -1;
        private string productType;
        private string productName;
        private int productCount;
        private int productPrice;
        static  public List<ProductIngridients> productList  = new List<ProductIngridients>();
        public ProductIngridients(string prodType, string prodName,int prodCount, int prodPrice)
        {
            productCount = prodCount;
            productName = prodName;
            productPrice = prodPrice;
            productType = prodType;
            id++;
        }
        static public void AddProduct(string prodType, string prodName, int prodCount, int prodPrice,DateTime time) 
        {
            productList.Add(new ProductIngridients(prodType,prodName,prodCount,prodPrice));
            ProductIngridients.SendProductToBase(productList,time);
        }
        static public void SendProductToBase(List<ProductIngridients> productsForSend,DateTime time)
        {
            DatabaseClass data = new DatabaseClass();
            string dateTime = Convert.ToDateTime(time).ToString("MM-dd-yyyy HH:mm:ss");
            MessageBox.Show(dateTime);

            string command = $"INSERT INTO ProductIngridients (Type,Name,Count) VALUES (" +
            $"N'{productsForSend[id].productType}'," +
            $"N'{productsForSend[id].productName}'," +
            $"N'{productsForSend[id].productCount}')";
            data.SendCommand(command);

            string command2 = $"INSERT INTO ProductBuyingPrice (Name,Price,Date) VALUES (" +
            $"N'{productsForSend[id].productName}',"+
            $"'{productsForSend[id].productPrice}'," +
            $"'{dateTime}')";
            data.SendCommand(command2);



        }
    }
}
