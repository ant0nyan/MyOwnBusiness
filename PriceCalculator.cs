using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CoffeShop
{
    public class PriceCalculator
    {
        private decimal monthExpense = 0;
        private decimal dayExpense = 0;
        private decimal expenseForType = 0;
        private decimal expenseForOneSaleProduct = 0;
        private int saleProductCount = 1;
        private int minCountOfSales = 1;
        private double profitPercent = 0;
        private double incomeTax = 0;
        private decimal productCost = 0;
        private decimal rent = 0;
        private decimal salary = 0;
        private decimal comunal = 0;
        private decimal amortization = 0;
        private decimal constTax = 0;
        private decimal other= 0;
        private int workDays;
        private decimal totalPrice;
        decimal totalPriceIncludeRSCAC;
        decimal totalPricePlusProfit;

        public PriceCalculator(
            decimal rent,
            decimal salary,
            decimal comunal,
            decimal amortization,
            decimal constTax,
            decimal other,
            double profitPercent,
            double incomeTax,
            int saleProductCount,
            int minCountOfSales,
            int workDays,
            decimal productCost)
        {

            this.rent = rent;
            this.salary = salary;
            this.comunal = comunal;
            this.amortization = amortization;
            this.constTax = constTax;
            this.profitPercent = profitPercent;
            this.other = other;
            this.incomeTax = incomeTax;
            this.saleProductCount = saleProductCount;
            this.minCountOfSales = minCountOfSales;
            this.workDays = workDays;
            this.productCost = productCost;

        }

        private void GetMonthExpense()
        {
            monthExpense = rent + salary + comunal + amortization + constTax + other;

        }
        private void GetDayExpense()
        {
            dayExpense = monthExpense / workDays;

        }
        private void GetExpenseForType()
        {
            expenseForType = dayExpense / saleProductCount;

        }

        private void GetExpenseForOneSaleProduct()
        {
            expenseForOneSaleProduct = expenseForType / minCountOfSales;

        }

       

        private void GetPriceIncludeRSCAC()
        {  totalPriceIncludeRSCAC = expenseForOneSaleProduct + productCost;

        }
        private void GetTotalPrice()
        {
            totalPricePlusProfit = (totalPriceIncludeRSCAC * (decimal)profitPercent) / 100+ totalPriceIncludeRSCAC;

            totalPrice =  totalPricePlusProfit +(totalPriceIncludeRSCAC * (decimal)profitPercent * (decimal)incomeTax) / 10000;



        }
        public decimal CalculateTotalPrice()
        {
            GetMonthExpense();
            GetDayExpense();
            GetExpenseForType();
            GetExpenseForOneSaleProduct();
            GetPriceIncludeRSCAC();
            GetTotalPrice();
            return totalPrice;
        }
        public decimal GetProfit()
        {
            return  (totalPriceIncludeRSCAC * (decimal)profitPercent) / 100;
        }

        private void ChangeDatasToBase()
        {
            DatabaseClass data = new DatabaseClass();
            string command = $"UPDATE CalculatorMonthDatas SET Rent = '{rent}',Salary = '{salary}',Comunal = '{comunal}',Amortizat = '{amortization}',ConstTax = '{constTax}',Other = '{other}',ProductCount = '{saleProductCount}',WorkDays = '{workDays}'";
            data.SendCommand(command);

            
        }
        public void SendCommandToBase()
        {
            ChangeDatasToBase();
        }

    }
}
