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
        private byte pieceOrGram;
        private int productMCFN;
        static  public List<ProductIngridients> productList  = new List<ProductIngridients>();
        public ProductIngridients(string prodType, string prodName,int prodCount, int prodPrice, byte pieceOrGram, int prodMCFN)
        {
            productCount = prodCount;
            productName = prodName;
            productPrice = prodPrice;
            productType = prodType;
            this.pieceOrGram = pieceOrGram;
            productMCFN = prodMCFN;
            id++;
            
        }
        static public void AddProduct(string prodType, string prodName, int prodCount, int prodPrice,DateTime time, byte pieceOrGram, int prodMCFN) 
        {
            productList.Add(new ProductIngridients(prodType,prodName,prodCount,prodPrice,pieceOrGram,prodMCFN));
            ProductIngridients.SendProductToBase(productList,time);
        }
        static public void SendProductToBase(List<ProductIngridients> productsForSend,DateTime time)
        {
            DatabaseClass data = new DatabaseClass();
            string dateTime = Convert.ToDateTime(time).ToString("MM-dd-yyyy HH:mm:ss");

            string command = $"INSERT INTO ProductIngridients (Type,Name,Count,PieceOrGram,MCFN) VALUES (" +
            $"N'{productsForSend[id].productType}'," +
            $"N'{productsForSend[id].productName}'," +
            $"N'{productsForSend[id].productCount}'," +
            $" '{productsForSend[id].pieceOrGram}'," +
            $" '{productsForSend[id].productMCFN}')";
            data.SendCommand(command);

            string command2 = $"INSERT INTO ProductBuyingPrice (Name,Price,Date) VALUES (" +
            $"N'{productsForSend[id].productName}',"+
            $"'{productsForSend[id].productPrice}'," +
            $"'{dateTime}')";
            data.SendCommand(command2);



        }
    }
}
