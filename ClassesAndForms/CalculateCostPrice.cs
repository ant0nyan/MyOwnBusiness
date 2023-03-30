using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class CalculateCostPrice : Form
    {
        List<double> neededCount= new List<double>();
        List<double> kilogramPcPrice = new List<double>();
        List<byte> kilogramOrPiece = new List<byte>();
        bool buttonClickFlag = false;
        bool buttonEditClickFlag = false;
        byte gramOrPiece;
        bool calculatingFlag = false;
        public CalculateCostPrice()
        {
            InitializeComponent();
        }
        private void requiredQuantityTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("The amount needed to make the product․", requiredQuantityTextBox);
            
        }
        private void priceTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("The price per kilogram or per piece of a given type of product․", priceTextBox);
        }
        private void nextButton_Click(object sender, EventArgs e)
        { double neededCountNumber;
          double kilogramOrPcPrice;
           
            if (double.TryParse(requiredQuantityTextBox.Text, out neededCountNumber) &&
                double.TryParse(priceTextBox.Text, out kilogramOrPcPrice) && 
                buttonClickFlag == true)
            {
                neededCount.Add(neededCountNumber);
                kilogramPcPrice.Add(kilogramOrPcPrice);
                kilogramOrPiece.Add(gramOrPiece);

                calculatingFlag = true;
            }
            else
            {
                MessageBox.Show("Please Input valid datas", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonClickFlag = false;
            requiredQuantityTextBox.Text = "";
            priceTextBox.Text = "";
            pieceButton.FillColor = Color.FromArgb(94, 148, 255);
            gramButton.FillColor = Color.FromArgb(94, 148, 255);
        }
        private void pieceButton_Click(object sender, EventArgs e)
        {
            PieceButtonChange(ref buttonClickFlag, pieceButton, gramButton);
        }
        private void gramButton_Click(object sender, EventArgs e)
        {
            GramButtonChange(ref buttonClickFlag, pieceButton, gramButton);
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (calculatingFlag == true)
            {
                ShowPanelVisibility(true);
                AddListBox();
                DialogResult dialog = MessageBox.Show($"Choose YES if you have entered all the data correctly", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Calculating();
                }
            }
            else
            {
                MessageBox.Show("Please Input valid datas", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double CountPrice(double neededCount ,double price,byte kiloOrPiece)
        {
            double costPrice=0;
            if (kiloOrPiece==0 )
            {
                costPrice=(neededCount / 1000) * price;
            }
            else 
            {
                costPrice = neededCount * price;    
            }
            return costPrice;

        }
        private string ShowElements(int index)
        {
            string allElements = string.Empty;
            string kiloOrGram = string.Empty;
                if (kilogramOrPiece[index]==0)
                {
                    kiloOrGram = " Gram";
                }
                else
                {
                    kiloOrGram = " Piece";
                }
                allElements = $"{index+1}. - {neededCount[index]} - {kilogramPcPrice[index]} - {kiloOrGram} \n";  
            return allElements;
        }
        private void ShowPanelVisibility(bool trueOrFalse)
        {
            showElementsPanel.Visible = trueOrFalse;
            showElementsListBox.Visible = trueOrFalse;
        }
        private void DeleteAllDatas()
        {
            kilogramOrPiece.Clear();
            kilogramPcPrice.Clear();
            neededCount.Clear();
            calculatingFlag = false;              
        }
        private void editButton_Click(object sender, EventArgs e)
        {

            int index = showElementsListBox.SelectedIndex;
            
            double neededCountNumber=0;
            double kilogramOrPcPrice=0;

            if (double.TryParse(needEditTextBox.Text, out neededCountNumber) &&
                double.TryParse(priceEditTextBox.Text, out kilogramOrPcPrice) &&
                buttonEditClickFlag == true)
            {
                EditButtonLogic(index, neededCountNumber, kilogramOrPcPrice);
                AddListBox();
                InitalStateValueShowPanel();
            }
            else
            {
                MessageBox.Show("Please Input valid datas", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AddInformationToTextBox(int index)
        {
            for (int i = 0; i < neededCount.Count; i++)
            {
                if (i == index)
                {
                    needEditTextBox.Text = neededCount[i].ToString();
                    priceEditTextBox.Text = kilogramPcPrice[i].ToString();
                }
            }
        }
        private void showElementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = showElementsListBox.SelectedIndex;
            AddInformationToTextBox(index);
           
        }
        private void AddListBox()
        {
            showElementsListBox.Items.Clear();
            for (int i = 0; i < neededCount.Count; i++)
            {
                showElementsListBox.Items.Add(ShowElements(i));
            }
        }
        private void pieceEditButton_Click(object sender, EventArgs e)
        {
            PieceButtonChange(ref buttonEditClickFlag, pieceEditButton, gramEditButton);
        }
        private void GramButtonChange(ref bool  flag, Guna2Button gram,Guna2Button piece )
        {
            flag = true;
            gramOrPiece = 0;
            gram.FillColor = Color.FromArgb(94, 148, 255);
            piece.FillColor = Color.FromArgb(0, 192, 0);
        }
        private void PieceButtonChange(ref bool flag, Guna2Button gram, Guna2Button piece)
        {
            flag = true;
            gram.FillColor = Color.FromArgb(0, 192, 0);
            gramOrPiece = 1;
            piece.FillColor = Color.FromArgb(94, 148, 255);
        }
        private void gramEditButton_Click(object sender, EventArgs e)
        {
            GramButtonChange(ref buttonEditClickFlag, pieceEditButton, gramEditButton);
        }
        private void readyButton_Click(object sender, EventArgs e)
        {
            showElementsPanel.Visible = false;
            Calculating();
        }
        private void Calculating()
        {
            ShowPanelVisibility(false);
            double costPrice = 0;
            for (int i = 0; i < neededCount.Count; i++)
            {
                neededCount[i] = CountPrice(neededCount[i], kilogramPcPrice[i], kilogramOrPiece[i]);
                costPrice += neededCount[i];
            }
            showPriceLabel.Text = $"Cost Price = {costPrice}";
            DeleteAllDatas();


        }
        private void InitalStateValueShowPanel()
        {
            buttonEditClickFlag = false;
            needEditTextBox.Text = "";
            priceEditTextBox.Text = "";
            pieceEditButton.FillColor = Color.FromArgb(94, 148, 255);
            gramEditButton.FillColor = Color.FromArgb(94, 148, 255);
        }
        private void EditButtonLogic(int index, double neededCountNumber,double kilogramOrPcPrice)
        {          
            for (int i = 0; i < neededCount.Count; i++)
            {
                if (i == index)
                {
                    neededCount[i] = neededCountNumber;
                    kilogramPcPrice[i] = kilogramOrPcPrice;
                    kilogramOrPiece[i] = gramOrPiece;
                }
            }
        }

     
    }
}
