/* * * * * * * * * * *
 * Warren Peterson * *
 * 6/23/2021 * * * * *
 * CST-227 * * * * * *
 * File IO with GUI  *
 * This is my own work
 * * * * * * * * * * */

namespace TextFileDataAccessDemoGUIApp
{
    partial class Form1
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
            this.loadFromFileBtn = new System.Windows.Forms.Button();
            this.personsListBox = new System.Windows.Forms.ListBox();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadFromFileBtn
            // 
            this.loadFromFileBtn.BackColor = System.Drawing.Color.Crimson;
            this.loadFromFileBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadFromFileBtn.ForeColor = System.Drawing.Color.White;
            this.loadFromFileBtn.Location = new System.Drawing.Point(48, 250);
            this.loadFromFileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadFromFileBtn.Name = "loadFromFileBtn";
            this.loadFromFileBtn.Size = new System.Drawing.Size(98, 26);
            this.loadFromFileBtn.TabIndex = 29;
            this.loadFromFileBtn.Text = "Load from File";
            this.loadFromFileBtn.UseVisualStyleBackColor = false;
            this.loadFromFileBtn.Click += new System.EventHandler(this.loadFromFileBtn_Click);
            // 
            // personsListBox
            // 
            this.personsListBox.BackColor = System.Drawing.Color.Black;
            this.personsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personsListBox.ForeColor = System.Drawing.Color.White;
            this.personsListBox.FormattingEnabled = true;
            this.personsListBox.ItemHeight = 15;
            this.personsListBox.Location = new System.Drawing.Point(195, 17);
            this.personsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.personsListBox.Name = "personsListBox";
            this.personsListBox.Size = new System.Drawing.Size(412, 304);
            this.personsListBox.TabIndex = 28;
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.BackColor = System.Drawing.Color.Lime;
            this.SaveToFileButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveToFileButton.ForeColor = System.Drawing.Color.Black;
            this.SaveToFileButton.Location = new System.Drawing.Point(48, 220);
            this.SaveToFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(98, 26);
            this.SaveToFileButton.TabIndex = 27;
            this.SaveToFileButton.Text = "Save to File";
            this.SaveToFileButton.UseVisualStyleBackColor = false;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.urlTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.urlTextBox.ForeColor = System.Drawing.Color.White;
            this.urlTextBox.Location = new System.Drawing.Point(88, 68);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(79, 23);
            this.urlTextBox.TabIndex = 26;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.White;
            this.lastNameTextBox.Location = new System.Drawing.Point(88, 42);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(79, 23);
            this.lastNameTextBox.TabIndex = 25;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextBox.ForeColor = System.Drawing.Color.White;
            this.firstNameTextBox.Location = new System.Drawing.Point(88, 17);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(79, 23);
            this.firstNameTextBox.TabIndex = 24;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.BackColor = System.Drawing.Color.Black;
            this.urlLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.urlLabel.ForeColor = System.Drawing.Color.White;
            this.urlLabel.Location = new System.Drawing.Point(61, 73);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(24, 15);
            this.urlLabel.TabIndex = 23;
            this.urlLabel.Text = "Url";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Black;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 46);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(65, 15);
            this.lastNameLabel.TabIndex = 22;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Black;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 22);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name";
            // 
            // addToListBtn
            // 
            this.addToListBtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.addToListBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addToListBtn.ForeColor = System.Drawing.Color.White;
            this.addToListBtn.Location = new System.Drawing.Point(19, 111);
            this.addToListBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(157, 37);
            this.addToListBtn.TabIndex = 20;
            this.addToListBtn.Text = "Add To List ->";
            this.addToListBtn.UseVisualStyleBackColor = false;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextFileDataAccessDemoGUIApp.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(622, 338);
            this.Controls.Add(this.loadFromFileBtn);
            this.Controls.Add(this.personsListBox);
            this.Controls.Add(this.SaveToFileButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.addToListBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "File IO Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFromFileBtn;
        private System.Windows.Forms.ListBox personsListBox;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button addToListBtn;
    }
}

