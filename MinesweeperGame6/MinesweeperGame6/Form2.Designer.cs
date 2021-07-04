
/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 6/25/2021 * *
 * * * Milestone 6 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

using System.Windows.Forms;

namespace MinesweeperGame6
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel gameBoardPanel;
        private System.Windows.Forms.ImageList gameImageList;
        private System.Windows.Forms.Timer gameTimer;

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
        }// End of Method

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gameBoardPanel = new System.Windows.Forms.Panel();
            this.gameImageList = new System.Windows.Forms.ImageList(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.turnsCountLabel = new System.Windows.Forms.Label();
            this.displayTimerLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameBoardPanel.Location = new System.Drawing.Point(9, 24);
            this.gameBoardPanel.Margin = new System.Windows.Forms.Padding(2);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.Size = new System.Drawing.Size(388, 375);
            this.gameBoardPanel.TabIndex = 2;
            // 
            // gameImageList
            // 
            this.gameImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.gameImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("gameImageList.ImageStream")));
            this.gameImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.gameImageList.Images.SetKeyName(0, "bomb.png");
            this.gameImageList.Images.SetKeyName(1, "flag.png");
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // turnsCountLabel
            // 
            this.turnsCountLabel.AutoSize = true;
            this.turnsCountLabel.Location = new System.Drawing.Point(452, 43);
            this.turnsCountLabel.Name = "turnsCountLabel";
            this.turnsCountLabel.Size = new System.Drawing.Size(0, 15);
            this.turnsCountLabel.TabIndex = 5;
            // 
            // displayTimerLabel
            // 
            this.displayTimerLabel.AutoSize = true;
            this.displayTimerLabel.Location = new System.Drawing.Point(452, 92);
            this.displayTimerLabel.Name = "displayTimerLabel";
            this.displayTimerLabel.Size = new System.Drawing.Size(0, 15);
            this.displayTimerLabel.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(322, 404);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 33);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "MINESWEEPER";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinesweeperGame6.Properties.Resources.purple_background;
            this.ClientSize = new System.Drawing.Size(407, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.displayTimerLabel);
            this.Controls.Add(this.turnsCountLabel);
            this.Controls.Add(this.gameBoardPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Minesweeper Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }// End of Method

        #endregion
        private Label turnsCountLabel;
        private Label displayTimerLabel;
        private Button ExitButton;
        private Label label1;
    }// End of Partial Class
}// End of Namespace