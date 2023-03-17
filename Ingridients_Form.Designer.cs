namespace CoffeShop
{
    partial class Ingridients_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingridients_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.ingridListBox = new System.Windows.Forms.ListBox();
            this.ingridCountTextBox = new System.Windows.Forms.TextBox();
            this.showAllIngrid = new System.Windows.Forms.Label();
            this.addIngridCountButton = new Guna.UI2.WinForms.Guna2Button();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.editingIngridCountAndName = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingridients Count";
            // 
            // ingridListBox
            // 
            this.ingridListBox.FormattingEnabled = true;
            this.ingridListBox.ItemHeight = 16;
            this.ingridListBox.Location = new System.Drawing.Point(247, 82);
            this.ingridListBox.Name = "ingridListBox";
            this.ingridListBox.Size = new System.Drawing.Size(152, 500);
            this.ingridListBox.TabIndex = 3;
            // 
            // ingridCountTextBox
            // 
            this.ingridCountTextBox.Location = new System.Drawing.Point(249, 676);
            this.ingridCountTextBox.Name = "ingridCountTextBox";
            this.ingridCountTextBox.Size = new System.Drawing.Size(152, 22);
            this.ingridCountTextBox.TabIndex = 4;
            // 
            // showAllIngrid
            // 
            this.showAllIngrid.AutoSize = true;
            this.showAllIngrid.Location = new System.Drawing.Point(25, 82);
            this.showAllIngrid.Name = "showAllIngrid";
            this.showAllIngrid.Size = new System.Drawing.Size(0, 16);
            this.showAllIngrid.TabIndex = 5;
            // 
            // addIngridCountButton
            // 
            this.addIngridCountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addIngridCountButton.Animated = true;
            this.addIngridCountButton.BorderRadius = 17;
            this.addIngridCountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addIngridCountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addIngridCountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addIngridCountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addIngridCountButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addIngridCountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addIngridCountButton.ForeColor = System.Drawing.Color.White;
            this.addIngridCountButton.Location = new System.Drawing.Point(247, 718);
            this.addIngridCountButton.Name = "addIngridCountButton";
            this.addIngridCountButton.Size = new System.Drawing.Size(154, 48);
            this.addIngridCountButton.TabIndex = 8;
            this.addIngridCountButton.Text = "Add";
            this.addIngridCountButton.Click += new System.EventHandler(this.addIngridCountButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Animated = true;
            this.saveButton.BorderRadius = 17;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(19, 718);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(152, 48);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editingIngridCountAndName
            // 
            this.editingIngridCountAndName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editingIngridCountAndName.Animated = true;
            this.editingIngridCountAndName.BorderRadius = 12;
            this.editingIngridCountAndName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editingIngridCountAndName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editingIngridCountAndName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editingIngridCountAndName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editingIngridCountAndName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editingIngridCountAndName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editingIngridCountAndName.ForeColor = System.Drawing.Color.White;
            this.editingIngridCountAndName.Location = new System.Drawing.Point(264, 38);
            this.editingIngridCountAndName.Name = "editingIngridCountAndName";
            this.editingIngridCountAndName.PressedDepth = 35;
            this.editingIngridCountAndName.Size = new System.Drawing.Size(116, 38);
            this.editingIngridCountAndName.TabIndex = 10;
            this.editingIngridCountAndName.Text = "Edit";
            this.editingIngridCountAndName.Click += new System.EventHandler(this.editingIngridCountAndName_Click);
            // 
            // Ingridients_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 778);
            this.Controls.Add(this.editingIngridCountAndName);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addIngridCountButton);
            this.Controls.Add(this.showAllIngrid);
            this.Controls.Add(this.ingridCountTextBox);
            this.Controls.Add(this.ingridListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingridients_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingridients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ingridients_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ingridListBox;
        private System.Windows.Forms.TextBox ingridCountTextBox;
        private System.Windows.Forms.Label showAllIngrid;
        private Guna.UI2.WinForms.Guna2Button addIngridCountButton;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2Button editingIngridCountAndName;
    }
}