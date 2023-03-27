using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    static public class IngridForSale 
    {
        static private int id = -1;

        static public List<int> idList = new List<int>();
        static public List<string> nameList = new List<string>();

        static public List<string> typeList = new List<string>();
        static public List<string> nameListForLabel = new List<string>();
        static public List<int> priceList = new List<int>();
        static public List<int> countList = new List<int>();

        static public List<int> idListToSendBase = new List<int>();
        static public List<int> countListToSendBase = new List<int>();

        static public void AddProduct(int prodId, string prodName)
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
        static public string listToStringFormat(List<int> dates) //List make to string + #
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
