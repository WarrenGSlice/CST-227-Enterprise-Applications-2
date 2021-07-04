/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 6/19/2021 * *
 * * * Milestone 2 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

using System.Windows.Forms;

namespace MinesweeperGame6
{
    partial class Results
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///Set Bindings
        BindingSource scoreListBinding = new BindingSource();

        private void SetBindings()
        {
            scoreListBinding.DataSource = PlayerStats.playerStats;
            listBox1.DataSource = scoreListBinding;
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Display";
        }

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
            this.TimerFormLabel = new System.Windows.Forms.Label();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerFormLabel
            // 
            this.TimerFormLabel.AutoSize = true;
            this.TimerFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerFormLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimerFormLabel.ForeColor = System.Drawing.Color.White;
            this.TimerFormLabel.Location = new System.Drawing.Point(60, 8);
            this.TimerFormLabel.Name = "TimerFormLabel";
            this.TimerFormLabel.Size = new System.Drawing.Size(295, 19);
            this.TimerFormLabel.TabIndex = 0;
            this.TimerFormLabel.Text = "These Are the Top High Scores";
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.Black;
            this.PlayAgainButton.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayAgainButton.ForeColor = System.Drawing.Color.Magenta;
            this.PlayAgainButton.Location = new System.Drawing.Point(30, 190);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(129, 32);
            this.PlayAgainButton.TabIndex = 3;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 144);
            this.listBox1.TabIndex = 4;
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Black;
            this.QuitButton.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuitButton.ForeColor = System.Drawing.Color.Red;
            this.QuitButton.Location = new System.Drawing.Point(258, 190);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(126, 32);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit Game";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinesweeperGame6.Properties.Resources.purple_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 313);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.TimerFormLabel);
            this.DoubleBuffered = true;
            this.Name = "Results";
            this.Text = "High Scores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Results_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerFormLabel;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button QuitButton;
    }
}