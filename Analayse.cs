using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace CoffeShop
{
    public partial class AdminPanel
    {
        int profitNumOne;
        int profitNumTwo;
        int profit;
        private string startDate;
        private string startDateDay =$"{DatabaseClass.DateTimeFormat(DateTime.Today)}";
        private string dateNow = $"{DatabaseClass.DateTimeFormat(DateTime.Now)}";
        private void todayButton_Click(object sender, EventArgs e)
        {
           
            GetTodayResultsSelling();
            GetTodayResultsBuying();
            GetProfit();
            
        }
        private void sevenDaysButton_Click(object sender, EventArgs e)
        {
            GetDaysResultSelling(-7);
            GetDaysResultBuying(-7);
            GetProfit();
        }
        private void monthButton_Click(object sender, EventArgs e)
        {
            GetDaysResultSelling(-30);
            GetDaysResultBuying(-30);
            GetProfit();
           
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
          string start=DatabaseClass.DateTimeFormat( dateTimePicker1.Value);
          string end= DatabaseClass.DateTimeFormat(dateTimePicker2.Value);

            GetDateWithUserInputTime(start, end);
            GetProfit();
        }
        private void GetTodayResultsSelling()
        {
            string command = $"SELECT SUM(PriceSalesProduct) FROM SalesProducts WHERE TimeSaleProduct >='{startDateDay}' AND TimeSaleProduct < '{dateNow}'";
            int total =dataBase.ReturnTotal(command);
            sellingLabel.Text= total.ToString();
            profitNumOne = total;
           
        }
        private void GetTodayResultsBuying()
        {
            string command = $"SELECT SUM(Price) FROM ProductBuyingPrice WHERE Date >='{startDateDay}' AND Date < '{dateNow}'";
            int total = dataBase.ReturnTotal(command);
            buyingLabel.Text = total.ToString();
            profitNumTwo = total;
        }
        private void GetDaysResultBuying(int days)
        {
            startDate = ReturnDataTime(days);
            string command = $"SELECT SUM(Price) FROM ProductBuyingPrice WHERE Date >='{startDate}' AND Date < '{dateNow}'";
            int total = dataBase.ReturnTotal(command);
            buyingLabel.Text = total.ToString();
            profitNumTwo = total;
        }
        private void GetDaysResultSelling(int days)
        {
            startDate = ReturnDataTime(days);
            string command = $"SELECT SUM(PriceSalesProduct) FROM SalesProducts WHERE TimeSaleProduct >='{startDate}' AND TimeSaleProduct < '{dateNow}'";
            int total = dataBase.ReturnTotal(command);
            sellingLabel.Text = total.ToString();
            profitNumOne = total;
        }
        private int GetProfit()
        {
             profit = profitNumOne - profitNumTwo;
          
            if (profit>0)
            {
                profitLabel.Text = profit.ToString();
                profitLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                profitLabel.Text = profit.ToString();
                profitLabel.ForeColor = System.Drawing.Color.Red;
            }
            return profit;
            
        }
        private string ReturnDataTime(int days)
        {
            string startDate = string.Empty;
            time = DateTime.Now;
            time = time.AddDays(days);
            startDate = $"{DatabaseClass.DateTimeFormat(time)}";
            return startDate;
        }
        private void GetDateWithUserInputTime(string startDate,string endDate)
        {
           
            string command = $"SELECT SUM(Price) FROM ProductBuyingPrice WHERE Date >='{startDate}' AND Date < '{endDate}'";
            int total = dataBase.ReturnTotal(command);
            buyingLabel.Text = total.ToString();
            profitNumTwo = total;

            
            string command2 = $"SELECT SUM(PriceSalesProduct) FROM SalesProducts WHERE TimeSaleProduct >='{startDate}' AND TimeSaleProduct < '{endDate}'";
            int total2 = dataBase.ReturnTotal(command2);
            sellingLabel.Text = total2.ToString();
            profitNumOne = total2;

        }
        private void DayProfit()
        {
            time = DateTime.Today;
            string timeWhene= DatabaseClass.DateTimeFormat( time.AddDays(-1));
          
            GetDateWithUserInputTime(timeWhene,startDateDay);

            profit = GetProfit();
            CheckDateProfit(DatabaseClass.DateTimeFormat(time));
            if (hasFlagProfit==false)
            {
                string command = $"INSERT INTO DayProfitTable (Day,Profit) VALUES ('{DatabaseClass.DateTimeFormat(time)}','{profit}')";
                dataBase.SendCommand(command);
            }
        }
        private void CheckDateProfit(string data)//check profit in orfer to 2 data does not go to the database
        {
            dataBase.OpenConnecttion();
            string command = $"SELECT COUNT(Day)  FROM DayProfitTable WHERE  Day='{data}'";
            SqlConnection connect = dataBase.getConnection(); ;
            SqlCommand comm = new SqlCommand(command, connect);
            int count = (Int32)comm.ExecuteScalar();
            if (count > 0)
            {
                hasFlagProfit = true;
            }
            else
            {
                hasFlagProfit = false;
            }
            dataBase.CloseConnecttion();
        }
        private void LiveChartsConnectWithBase()// Create live charts 
        {
            SqlConnection sqlconnct = dataBase.getConnection();
            dataBase.OpenConnecttion();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT * FROM DayProfitTable",sqlconnct);
            DataSet dataSet = new DataSet();
            sqlAdapter.Fill(dataSet,"DayProfitTable");
            DataTable table = dataSet.Tables["DayProfitTable"];

            cartesianChart1.LegendLocation = LegendLocation.Bottom;

            SeriesCollection series = new SeriesCollection();
            ChartValues<int> profitValues = new ChartValues<int>();
            List<string> dates = new List<string>();

            foreach (DataRow row in table.Rows)
            {
                profitValues.Add(Convert.ToInt32(row["Profit"]));
                dates.Add(Convert.ToDateTime(row["Day"]).ToShortDateString());
            }

            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis()
            {
                Title = "",
                Labels = dates
            }); 
            
            LineSeries lineSeries = new LineSeries();
            lineSeries.Title = "Profit";
            lineSeries.Values = profitValues;
            series.Add(lineSeries);

            cartesianChart1.Series = series;

        }
    }
}
