
namespace MineSweeperGUI
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
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.easyCheckBox = new System.Windows.Forms.CheckBox();
            this.moderateCheckBox = new System.Windows.Forms.CheckBox();
            this.hardCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(180, 80);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(118, 20);
            this.difficultyLabel.TabIndex = 4;
            this.difficultyLabel.Text = "Select Difficulty";
            // 
            // easyCheckBox
            // 
            this.easyCheckBox.AutoSize = true;
            this.easyCheckBox.Location = new System.Drawing.Point(184, 122);
            this.easyCheckBox.Name = "easyCheckBox";
            this.easyCheckBox.Size = new System.Drawing.Size(70, 24);
            this.easyCheckBox.TabIndex = 5;
            this.easyCheckBox.Text = "Easy";
            this.easyCheckBox.UseVisualStyleBackColor = true;
            this.easyCheckBox.CheckedChanged += new System.EventHandler(this.easyCheckBox_CheckedChanged);
            // 
            // moderateCheckBox
            // 
            this.moderateCheckBox.AutoSize = true;
            this.moderateCheckBox.Location = new System.Drawing.Point(184, 152);
            this.moderateCheckBox.Name = "moderateCheckBox";
            this.moderateCheckBox.Size = new System.Drawing.Size(103, 24);
            this.moderateCheckBox.TabIndex = 6;
            this.moderateCheckBox.Text = "Moderate";
            this.moderateCheckBox.UseVisualStyleBackColor = true;
            this.moderateCheckBox.CheckedChanged += new System.EventHandler(this.moderateCheckBox_CheckedChanged);
            // 
            // hardCheckBox
            // 
            this.hardCheckBox.AutoSize = true;
            this.hardCheckBox.Location = new System.Drawing.Point(185, 182);
            this.hardCheckBox.Name = "hardCheckBox";
            this.hardCheckBox.Size = new System.Drawing.Size(70, 24);
            this.hardCheckBox.TabIndex = 7;
            this.hardCheckBox.Text = "Hard";
            this.hardCheckBox.UseVisualStyleBackColor = true;
            this.hardCheckBox.CheckedChanged += new System.EventHandler(this.hardCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 387);
            this.Controls.Add(this.hardCheckBox);
            this.Controls.Add(this.moderateCheckBox);
            this.Controls.Add(this.easyCheckBox);
            this.Controls.Add(this.difficultyLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.CheckBox easyCheckBox;
        private System.Windows.Forms.CheckBox moderateCheckBox;
        private System.Windows.Forms.CheckBox hardCheckBox;
    }
}

