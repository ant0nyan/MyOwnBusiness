namespace CoffeShop
{
    partial class CalculateCostPrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateCostPrice));
            this.label1 = new System.Windows.Forms.Label();
            this.gramButton = new Guna.UI2.WinForms.Guna2Button();
            this.pieceButton = new Guna.UI2.WinForms.Guna2Button();
            this.requiredQuantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.showPriceLabel = new System.Windows.Forms.Label();
            this.nextButton = new Guna.UI2.WinForms.Guna2Button();
            this.showElementsPanel = new System.Windows.Forms.Panel();
            this.gramEditButton = new Guna.UI2.WinForms.Guna2Button();
            this.pieceEditButton = new Guna.UI2.WinForms.Guna2Button();
            this.priceEditTextBox = new System.Windows.Forms.TextBox();
            this.needEditTextBox = new System.Windows.Forms.TextBox();
            this.readyButton = new Guna.UI2.WinForms.Guna2Button();
            this.editButton = new Guna.UI2.WinForms.Guna2Button();
            this.showElementsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showElementsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate Cost Price";
            // 
            // gramButton
            // 
            this.gramButton.BorderRadius = 7;
            this.gramButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gramButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gramButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gramButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gramButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gramButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gramButton.ForeColor = System.Drawing.Color.White;
            this.gramButton.Location = new System.Drawing.Point(239, 237);
            this.gramButton.Name = "gramButton";
            this.gramButton.Size = new System.Drawing.Size(85, 28);
            this.gramButton.TabIndex = 34;
            this.gramButton.Text = "Gram";
            this.gramButton.Click += new System.EventHandler(this.gramButton_Click);
            // 
            // pieceButton
            // 
            this.pieceButton.BorderRadius = 7;
            this.pieceButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pieceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pieceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pieceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pieceButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pieceButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pieceButton.ForeColor = System.Drawing.Color.White;
            this.pieceButton.Location = new System.Drawing.Point(138, 237);
            this.pieceButton.Name = "pieceButton";
            this.pieceButton.Size = new System.Drawing.Size(89, 28);
            this.pieceButton.TabIndex = 33;
            this.pieceButton.Text = "Piece";
            this.pieceButton.Click += new System.EventHandler(this.pieceButton_Click);
            // 
            // requiredQuantityTextBox
            // 
            this.requiredQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredQuantityTextBox.Location = new System.Drawing.Point(138, 110);
            this.requiredQuantityTextBox.Multiline = true;
            this.requiredQuantityTextBox.Name = "requiredQuantityTextBox";
            this.requiredQuantityTextBox.Size = new System.Drawing.Size(186, 34);
            this.requiredQuantityTextBox.TabIndex = 35;
            this.requiredQuantityTextBox.MouseHover += new System.EventHandler(this.requiredQuantityTextBox_MouseHover);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(138, 165);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(186, 34);
            this.priceTextBox.TabIndex = 36;
            this.priceTextBox.MouseHover += new System.EventHandler(this.priceTextBox_MouseHover);
            // 
            // calculateButton
            // 
            this.calculateButton.BorderRadius = 7;
            this.calculateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.calculateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.calculateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calculateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.calculateButton.FillColor = System.Drawing.Color.LimeGreen;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(149, 448);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(148, 41);
            this.calculateButton.TabIndex = 37;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showPriceLabel
            // 
            this.showPriceLabel.AutoSize = true;
            this.showPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPriceLabel.Location = new System.Drawing.Point(38, 373);
            this.showPriceLabel.Name = "showPriceLabel";
            this.showPriceLabel.Size = new System.Drawing.Size(0, 32);
            this.showPriceLabel.TabIndex = 38;
            // 
            // nextButton
            // 
            this.nextButton.BorderRadius = 7;
            this.nextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nextButton.FillColor = System.Drawing.Color.DarkViolet;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(173, 284);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(101, 31);
            this.nextButton.TabIndex = 39;
            this.nextButton.Text = "Next";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // showElementsPanel
            // 
            this.showElementsPanel.Controls.Add(this.gramEditButton);
            this.showElementsPanel.Controls.Add(this.pieceEditButton);
            this.showElementsPanel.Controls.Add(this.priceEditTextBox);
            this.showElementsPanel.Controls.Add(this.needEditTextBox);
            this.showElementsPanel.Controls.Add(this.readyButton);
            this.showElementsPanel.Controls.Add(this.editButton);
            this.showElementsPanel.Controls.Add(this.showElementsListBox);
            this.showElementsPanel.Location = new System.Drawing.Point(1, 88);
            this.showElementsPanel.Name = "showElementsPanel";
            this.showElementsPanel.Size = new System.Drawing.Size(391, 463);
            this.showElementsPanel.TabIndex = 40;
            this.showElementsPanel.Visible = false;
            // 
            // gramEditButton
            // 
            this.gramEditButton.BorderRadius = 7;
            this.gramEditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gramEditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gramEditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gramEditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gramEditButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gramEditButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gramEditButton.ForeColor = System.Drawing.Color.White;
            this.gramEditButton.Location = new System.Drawing.Point(303, 294);
            this.gramEditButton.Name = "gramEditButton";
            this.gramEditButton.Size = new System.Drawing.Size(40, 26);
            this.gramEditButton.TabIndex = 45;
            this.gramEditButton.Text = "Gram";
            this.gramEditButton.Click += new System.EventHandler(this.gramEditButton_Click);
            // 
            // pieceEditButton
            // 
            this.pieceEditButton.BorderRadius = 7;
            this.pieceEditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pieceEditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pieceEditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pieceEditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pieceEditButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pieceEditButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pieceEditButton.ForeColor = System.Drawing.Color.White;
            this.pieceEditButton.Location = new System.Drawing.Point(254, 294);
            this.pieceEditButton.Name = "pieceEditButton";
            this.pieceEditButton.Size = new System.Drawing.Size(43, 26);
            this.pieceEditButton.TabIndex = 44;
            this.pieceEditButton.Text = "P";
            this.pieceEditButton.Click += new System.EventHandler(this.pieceEditButton_Click);
            // 
            // priceEditTextBox
            // 
            this.priceEditTextBox.Location = new System.Drawing.Point(157, 294);
            this.priceEditTextBox.Name = "priceEditTextBox";
            this.priceEditTextBox.Size = new System.Drawing.Size(69, 22);
            this.priceEditTextBox.TabIndex = 43;
            // 
            // needEditTextBox
            // 
            this.needEditTextBox.Location = new System.Drawing.Point(72, 294);
            this.needEditTextBox.Name = "needEditTextBox";
            this.needEditTextBox.Size = new System.Drawing.Size(69, 22);
            this.needEditTextBox.TabIndex = 42;
            // 
            // readyButton
            // 
            this.readyButton.BorderRadius = 7;
            this.readyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.readyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.readyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.readyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.readyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.readyButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readyButton.ForeColor = System.Drawing.Color.White;
            this.readyButton.Location = new System.Drawing.Point(157, 385);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(101, 31);
            this.readyButton.TabIndex = 41;
            this.readyButton.Text = "Ready";
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // editButton
            // 
            this.editButton.BorderRadius = 7;
            this.editButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editButton.FillColor = System.Drawing.Color.DarkViolet;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(157, 339);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(101, 31);
            this.editButton.TabIndex = 40;
            this.editButton.Text = "Edit ";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // showElementsListBox
            // 
            this.showElementsListBox.FormattingEnabled = true;
            this.showElementsListBox.ItemHeight = 16;
            this.showElementsListBox.Location = new System.Drawing.Point(72, 26);
            this.showElementsListBox.Name = "showElementsListBox";
            this.showElementsListBox.Size = new System.Drawing.Size(265, 244);
            this.showElementsListBox.TabIndex = 0;
            this.showElementsListBox.Visible = false;
            this.showElementsListBox.SelectedIndexChanged += new System.EventHandler(this.showElementsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Gram/Piece";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Price Kg/Pc";
            // 
            // CalculateCostPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.showElementsPanel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.showPriceLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.requiredQuantityTextBox);
            this.Controls.Add(this.gramButton);
            this.Controls.Add(this.pieceButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.Name = "CalculateCostPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculateCostPricecs";
            this.showElementsPanel.ResumeLayout(false);
            this.showElementsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button gramButton;
        private Guna.UI2.WinForms.Guna2Button pieceButton;
        private System.Windows.Forms.TextBox requiredQuantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private Guna.UI2.WinForms.Guna2Button calculateButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label showPriceLabel;
        private Guna.UI2.WinForms.Guna2Button nextButton;
        private System.Windows.Forms.Panel showElementsPanel;
        private System.Windows.Forms.ListBox showElementsListBox;
        private Guna.UI2.WinForms.Guna2Button readyButton;
        private Guna.UI2.WinForms.Guna2Button editButton;
        private Guna.UI2.WinForms.Guna2Button gramEditButton;
        private Guna.UI2.WinForms.Guna2Button pieceEditButton;
        private System.Windows.Forms.TextBox priceEditTextBox;
        private System.Windows.Forms.TextBox needEditTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}