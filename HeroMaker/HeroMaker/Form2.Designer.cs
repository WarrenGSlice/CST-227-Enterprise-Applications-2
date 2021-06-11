/* * * * * * * * * * *
 * Warren Peterson * *
 * 6/11/2021 CST-227
 * Acitivty 4 * * * *
 * Hero Maker dual form
 * This is my own work
 * * * * * * * * * * */

namespace HeroMaker
{
    partial class Form2
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
            this.heroListBox = new System.Windows.Forms.ListBox();
            this.heroLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // heroListBox
            // 
            this.heroListBox.BackColor = System.Drawing.Color.Red;
            this.heroListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heroListBox.FormattingEnabled = true;
            this.heroListBox.ItemHeight = 20;
            this.heroListBox.Location = new System.Drawing.Point(26, 48);
            this.heroListBox.Margin = new System.Windows.Forms.Padding(2);
            this.heroListBox.Name = "heroListBox";
            this.heroListBox.Size = new System.Drawing.Size(294, 264);
            this.heroListBox.TabIndex = 0;
            this.heroListBox.SelectedIndexChanged += new System.EventHandler(this.heroListBox_SelectedIndexChanged);
            // 
            // heroLabel
            // 
            this.heroLabel.AutoSize = true;
            this.heroLabel.BackColor = System.Drawing.Color.Transparent;
            this.heroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heroLabel.ForeColor = System.Drawing.Color.White;
            this.heroLabel.Location = new System.Drawing.Point(26, 26);
            this.heroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heroLabel.Name = "heroLabel";
            this.heroLabel.Size = new System.Drawing.Size(54, 21);
            this.heroLabel.TabIndex = 1;
            this.heroLabel.Text = "Heros";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutLabel.ForeColor = System.Drawing.Color.White;
            this.aboutLabel.Location = new System.Drawing.Point(341, 26);
            this.aboutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(57, 21);
            this.aboutLabel.TabIndex = 2;
            this.aboutLabel.Text = "About";
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Lime;
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.okBtn.FlatAppearance.BorderSize = 3;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.okBtn.Location = new System.Drawing.Point(26, 326);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(121, 39);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Okay";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BackColor = System.Drawing.Color.Red;
            this.aboutTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutTextBox.Location = new System.Drawing.Point(341, 49);
            this.aboutTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(508, 273);
            this.aboutTextBox.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeroMaker.Properties.Resources.BlueSquaresFloatingSmall;
            this.ClientSize = new System.Drawing.Size(877, 398);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.heroLabel);
            this.Controls.Add(this.heroListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox heroListBox;
        private System.Windows.Forms.Label heroLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox aboutTextBox;
    }
}