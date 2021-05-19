/* * * * * * * * * * *
 * Warren Peterson * *
 * This is my own work
 * 5/19/2021 CST-227 *
 * Car Shop Application
 * * * * * * * * * * */
namespace CarProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateCarGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateACarButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.MilesTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CarInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.CarInventoryListBox = new System.Windows.Forms.ListBox();
            this.ShoppingCartGroupBox = new System.Windows.Forms.GroupBox();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.ClearFieldsButton = new System.Windows.Forms.Button();
            this.CreateCarGroupBox.SuspendLayout();
            this.CarInventoryGroupBox.SuspendLayout();
            this.ShoppingCartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCarGroupBox
            // 
            this.CreateCarGroupBox.Controls.Add(this.CreateACarButton);
            this.CreateCarGroupBox.Controls.Add(this.ColorTextBox);
            this.CreateCarGroupBox.Controls.Add(this.MilesTextBox);
            this.CreateCarGroupBox.Controls.Add(this.PriceTextBox);
            this.CreateCarGroupBox.Controls.Add(this.ModelTextBox);
            this.CreateCarGroupBox.Controls.Add(this.MakeTextBox);
            this.CreateCarGroupBox.Controls.Add(this.label5);
            this.CreateCarGroupBox.Controls.Add(this.label4);
            this.CreateCarGroupBox.Controls.Add(this.label3);
            this.CreateCarGroupBox.Controls.Add(this.label2);
            this.CreateCarGroupBox.Controls.Add(this.label1);
            this.CreateCarGroupBox.Location = new System.Drawing.Point(22, 21);
            this.CreateCarGroupBox.Name = "CreateCarGroupBox";
            this.CreateCarGroupBox.Size = new System.Drawing.Size(214, 202);
            this.CreateCarGroupBox.TabIndex = 0;
            this.CreateCarGroupBox.TabStop = false;
            this.CreateCarGroupBox.Text = "Create a Car :";
            // 
            // CreateACarButton
            // 
            this.CreateACarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateACarButton.Location = new System.Drawing.Point(84, 171);
            this.CreateACarButton.Name = "CreateACarButton";
            this.CreateACarButton.Size = new System.Drawing.Size(96, 23);
            this.CreateACarButton.TabIndex = 10;
            this.CreateACarButton.Text = "Create Car";
            this.CreateACarButton.UseVisualStyleBackColor = true;
            this.CreateACarButton.Click += new System.EventHandler(this.CreateACarButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(66, 142);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(141, 23);
            this.ColorTextBox.TabIndex = 9;
            // 
            // MilesTextBox
            // 
            this.MilesTextBox.Location = new System.Drawing.Point(66, 113);
            this.MilesTextBox.Name = "MilesTextBox";
            this.MilesTextBox.Size = new System.Drawing.Size(141, 23);
            this.MilesTextBox.TabIndex = 8;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(67, 84);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(141, 23);
            this.PriceTextBox.TabIndex = 7;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(67, 55);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(141, 23);
            this.ModelTextBox.TabIndex = 6;
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Location = new System.Drawing.Point(67, 27);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.Size = new System.Drawing.Size(141, 23);
            this.MakeTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miles :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make :";
            // 
            // CarInventoryGroupBox
            // 
            this.CarInventoryGroupBox.Controls.Add(this.CarInventoryListBox);
            this.CarInventoryGroupBox.Location = new System.Drawing.Point(261, 21);
            this.CarInventoryGroupBox.Name = "CarInventoryGroupBox";
            this.CarInventoryGroupBox.Size = new System.Drawing.Size(243, 382);
            this.CarInventoryGroupBox.TabIndex = 1;
            this.CarInventoryGroupBox.TabStop = false;
            this.CarInventoryGroupBox.Text = "Car Inventory :";
            // 
            // CarInventoryListBox
            // 
            this.CarInventoryListBox.FormattingEnabled = true;
            this.CarInventoryListBox.ItemHeight = 15;
            this.CarInventoryListBox.Location = new System.Drawing.Point(7, 23);
            this.CarInventoryListBox.Name = "CarInventoryListBox";
            this.CarInventoryListBox.Size = new System.Drawing.Size(230, 349);
            this.CarInventoryListBox.TabIndex = 0;
            // 
            // ShoppingCartGroupBox
            // 
            this.ShoppingCartGroupBox.Controls.Add(this.ShoppingCartListBox);
            this.ShoppingCartGroupBox.Location = new System.Drawing.Point(682, 21);
            this.ShoppingCartGroupBox.Name = "ShoppingCartGroupBox";
            this.ShoppingCartGroupBox.Size = new System.Drawing.Size(272, 342);
            this.ShoppingCartGroupBox.TabIndex = 2;
            this.ShoppingCartGroupBox.TabStop = false;
            this.ShoppingCartGroupBox.Text = "Shopping Cart :";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 15;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(6, 22);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(260, 319);
            this.ShoppingCartListBox.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddToCartButton.Location = new System.Drawing.Point(545, 168);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(96, 23);
            this.AddToCartButton.TabIndex = 11;
            this.AddToCartButton.Text = "Add To Cart  ->";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckoutButton.Location = new System.Drawing.Point(796, 380);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(96, 23);
            this.CheckoutButton.TabIndex = 12;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Cost :";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(796, 416);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(90, 15);
            this.TotalCostLabel.TabIndex = 13;
            this.TotalCostLabel.Text = "$ some amount";
            // 
            // ClearFieldsButton
            // 
            this.ClearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearFieldsButton.Location = new System.Drawing.Point(106, 254);
            this.ClearFieldsButton.Name = "ClearFieldsButton";
            this.ClearFieldsButton.Size = new System.Drawing.Size(96, 23);
            this.ClearFieldsButton.TabIndex = 11;
            this.ClearFieldsButton.Text = "Clear Fields";
            this.ClearFieldsButton.UseVisualStyleBackColor = true;
            this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(991, 452);
            this.Controls.Add(this.ClearFieldsButton);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ShoppingCartGroupBox);
            this.Controls.Add(this.CarInventoryGroupBox);
            this.Controls.Add(this.CreateCarGroupBox);
            this.Name = "Form1";
            this.Text = "Car Shop Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CreateCarGroupBox.ResumeLayout(false);
            this.CreateCarGroupBox.PerformLayout();
            this.CarInventoryGroupBox.ResumeLayout(false);
            this.ShoppingCartGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateCarGroupBox;
        private System.Windows.Forms.Button CreateACarButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox MilesTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CarInventoryGroupBox;
        private System.Windows.Forms.ListBox CarInventoryListBox;
        private System.Windows.Forms.GroupBox ShoppingCartGroupBox;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Button ClearFieldsButton;
    }
}

