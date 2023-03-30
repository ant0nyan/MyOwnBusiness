namespace CoffeShop
{
    partial class Employer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employer));
            this.addButtonEmployer = new Guna.UI2.WinForms.Guna2Button();
            this.saveButtonEmployer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.employerCountLabel = new System.Windows.Forms.Label();
            this.employerPriceLabel = new System.Windows.Forms.Label();
            this.employerNameLabel = new System.Windows.Forms.Label();
            this.employerTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.showTotal = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.employerDataGridView = new System.Windows.Forms.DataGridView();
            this.countNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.firstCountLabel = new System.Windows.Forms.Label();
            this.firstPriceLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstTypeLabel = new System.Windows.Forms.Label();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchButtonEmployer = new System.Windows.Forms.Button();
            this.serachTextBoxEmployer = new System.Windows.Forms.TextBox();
            this.refreshButtonEmployerPanel = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButtonEmployer
            // 
            this.addButtonEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButtonEmployer.Animated = true;
            this.addButtonEmployer.BorderRadius = 17;
            this.addButtonEmployer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButtonEmployer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButtonEmployer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButtonEmployer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButtonEmployer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButtonEmployer.ForeColor = System.Drawing.Color.White;
            this.addButtonEmployer.Location = new System.Drawing.Point(1262, 774);
            this.addButtonEmployer.Name = "addButtonEmployer";
            this.addButtonEmployer.Size = new System.Drawing.Size(142, 48);
            this.addButtonEmployer.TabIndex = 7;
            this.addButtonEmployer.Text = "Add";
            this.addButtonEmployer.Click += new System.EventHandler(this.addButtonEmployer_Click);
            // 
            // saveButtonEmployer
            // 
            this.saveButtonEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButtonEmployer.Animated = true;
            this.saveButtonEmployer.BorderRadius = 17;
            this.saveButtonEmployer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButtonEmployer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButtonEmployer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButtonEmployer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButtonEmployer.FillColor = System.Drawing.Color.Lime;
            this.saveButtonEmployer.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButtonEmployer.ForeColor = System.Drawing.Color.White;
            this.saveButtonEmployer.Location = new System.Drawing.Point(51, 774);
            this.saveButtonEmployer.Name = "saveButtonEmployer";
            this.saveButtonEmployer.Size = new System.Drawing.Size(298, 48);
            this.saveButtonEmployer.TabIndex = 9;
            this.saveButtonEmployer.Text = "Save";
            this.saveButtonEmployer.Click += new System.EventHandler(this.saveButtonEmployer_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Controls.Add(this.employerCountLabel);
            this.guna2Panel1.Controls.Add(this.employerPriceLabel);
            this.guna2Panel1.Controls.Add(this.employerNameLabel);
            this.guna2Panel1.Controls.Add(this.employerTypeLabel);
            this.guna2Panel1.Location = new System.Drawing.Point(51, 53);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(451, 617);
            this.guna2Panel1.TabIndex = 10;
            // 
            // employerCountLabel
            // 
            this.employerCountLabel.AutoSize = true;
            this.employerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employerCountLabel.Location = new System.Drawing.Point(388, 9);
            this.employerCountLabel.Name = "employerCountLabel";
            this.employerCountLabel.Size = new System.Drawing.Size(0, 22);
            this.employerCountLabel.TabIndex = 8;
            // 
            // employerPriceLabel
            // 
            this.employerPriceLabel.AutoSize = true;
            this.employerPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employerPriceLabel.Location = new System.Drawing.Point(310, 9);
            this.employerPriceLabel.Name = "employerPriceLabel";
            this.employerPriceLabel.Size = new System.Drawing.Size(0, 22);
            this.employerPriceLabel.TabIndex = 7;
            // 
            // employerNameLabel
            // 
            this.employerNameLabel.AutoSize = true;
            this.employerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employerNameLabel.Location = new System.Drawing.Point(152, 9);
            this.employerNameLabel.Name = "employerNameLabel";
            this.employerNameLabel.Size = new System.Drawing.Size(0, 22);
            this.employerNameLabel.TabIndex = 6;
            // 
            // employerTypeLabel
            // 
            this.employerTypeLabel.AutoSize = true;
            this.employerTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employerTypeLabel.Location = new System.Drawing.Point(16, 9);
            this.employerTypeLabel.Name = "employerTypeLabel";
            this.employerTypeLabel.Size = new System.Drawing.Size(0, 22);
            this.employerTypeLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Count";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel2.Controls.Add(this.showTotal);
            this.guna2Panel2.Controls.Add(this.totalLabel);
            this.guna2Panel2.Location = new System.Drawing.Point(51, 689);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(451, 56);
            this.guna2Panel2.TabIndex = 11;
            // 
            // showTotal
            // 
            this.showTotal.AutoSize = true;
            this.showTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTotal.Location = new System.Drawing.Point(308, 12);
            this.showTotal.Name = "showTotal";
            this.showTotal.Size = new System.Drawing.Size(0, 29);
            this.showTotal.TabIndex = 1;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 12);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(68, 29);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total";
            // 
            // employerDataGridView
            // 
            this.employerDataGridView.AllowUserToAddRows = false;
            this.employerDataGridView.AllowUserToDeleteRows = false;
            this.employerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employerDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employerDataGridView.Location = new System.Drawing.Point(775, 92);
            this.employerDataGridView.Name = "employerDataGridView";
            this.employerDataGridView.ReadOnly = true;
            this.employerDataGridView.RowHeadersWidth = 51;
            this.employerDataGridView.RowTemplate.Height = 24;
            this.employerDataGridView.Size = new System.Drawing.Size(629, 578);
            this.employerDataGridView.TabIndex = 13;
            this.employerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employerDataGridView_CellClick);
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.countNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.countNumericUpDown.Location = new System.Drawing.Point(1262, 689);
            this.countNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(142, 56);
            this.countNumericUpDown.TabIndex = 14;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Panel3.Controls.Add(this.firstCountLabel);
            this.guna2Panel3.Controls.Add(this.firstPriceLabel);
            this.guna2Panel3.Controls.Add(this.firstNameLabel);
            this.guna2Panel3.Controls.Add(this.firstTypeLabel);
            this.guna2Panel3.Location = new System.Drawing.Point(775, 689);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(480, 56);
            this.guna2Panel3.TabIndex = 15;
            // 
            // firstCountLabel
            // 
            this.firstCountLabel.AutoSize = true;
            this.firstCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstCountLabel.Location = new System.Drawing.Point(481, 32);
            this.firstCountLabel.Name = "firstCountLabel";
            this.firstCountLabel.Size = new System.Drawing.Size(0, 18);
            this.firstCountLabel.TabIndex = 12;
            // 
            // firstPriceLabel
            // 
            this.firstPriceLabel.AutoSize = true;
            this.firstPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPriceLabel.Location = new System.Drawing.Point(389, 12);
            this.firstPriceLabel.Name = "firstPriceLabel";
            this.firstPriceLabel.Size = new System.Drawing.Size(0, 22);
            this.firstPriceLabel.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(231, 12);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(0, 22);
            this.firstNameLabel.TabIndex = 10;
            // 
            // firstTypeLabel
            // 
            this.firstTypeLabel.AutoSize = true;
            this.firstTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTypeLabel.Location = new System.Drawing.Point(95, 12);
            this.firstTypeLabel.Name = "firstTypeLabel";
            this.firstTypeLabel.Size = new System.Drawing.Size(0, 22);
            this.firstTypeLabel.TabIndex = 9;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetButton.Animated = true;
            this.resetButton.BorderRadius = 17;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.FillColor = System.Drawing.Color.Red;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(355, 774);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(144, 48);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchButtonEmployer
            // 
            this.searchButtonEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButtonEmployer.Location = new System.Drawing.Point(1232, 22);
            this.searchButtonEmployer.Name = "searchButtonEmployer";
            this.searchButtonEmployer.Size = new System.Drawing.Size(40, 30);
            this.searchButtonEmployer.TabIndex = 29;
            this.searchButtonEmployer.UseVisualStyleBackColor = true;
            // 
            // serachTextBoxEmployer
            // 
            this.serachTextBoxEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serachTextBoxEmployer.Location = new System.Drawing.Point(1300, 22);
            this.serachTextBoxEmployer.Name = "serachTextBoxEmployer";
            this.serachTextBoxEmployer.Size = new System.Drawing.Size(100, 22);
            this.serachTextBoxEmployer.TabIndex = 28;
            this.serachTextBoxEmployer.TextChanged += new System.EventHandler(this.serachTextBoxEmployer_TextChanged);
            // 
            // refreshButtonEmployerPanel
            // 
            this.refreshButtonEmployerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButtonEmployerPanel.Location = new System.Drawing.Point(1171, 22);
            this.refreshButtonEmployerPanel.Name = "refreshButtonEmployerPanel";
            this.refreshButtonEmployerPanel.Size = new System.Drawing.Size(40, 30);
            this.refreshButtonEmployerPanel.TabIndex = 27;
            this.refreshButtonEmployerPanel.UseVisualStyleBackColor = true;
            // 
            // Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 879);
            this.Controls.Add(this.searchButtonEmployer);
            this.Controls.Add(this.serachTextBoxEmployer);
            this.Controls.Add(this.refreshButtonEmployerPanel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.countNumericUpDown);
            this.Controls.Add(this.employerDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButtonEmployer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButtonEmployer);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employer";
            this.Text = "Employe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employe_FormClosed);
            this.Load += new System.EventHandler(this.Employe_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button addButtonEmployer;
        private Guna.UI2.WinForms.Guna2Button saveButtonEmployer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView employerDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label employerTypeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label employerCountLabel;
        private System.Windows.Forms.Label employerPriceLabel;
        private System.Windows.Forms.Label employerNameLabel;
        private Guna.UI2.WinForms.Guna2NumericUpDown countNumericUpDown;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label firstCountLabel;
        private System.Windows.Forms.Label firstPriceLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label firstTypeLabel;
        private System.Windows.Forms.Label showTotal;
        private System.Windows.Forms.Label totalLabel;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private System.Windows.Forms.Button searchButtonEmployer;
        private System.Windows.Forms.TextBox serachTextBoxEmployer;
        private System.Windows.Forms.Button refreshButtonEmployerPanel;
    }
}