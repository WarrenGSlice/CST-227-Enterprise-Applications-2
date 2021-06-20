
/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 6/19/2021 * *
 * * * Milestone 2 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

using System.Windows.Forms;

namespace MinesweeperGame5
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
        }

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
            this.turnsLabel = new System.Windows.Forms.Label();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.turnsCountLabel = new System.Windows.Forms.Label();
            this.displayTimerLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameBoardPanel
            // 
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
            // turnsLabel
            // 
            this.turnsLabel.AutoSize = true;
            this.turnsLabel.Location = new System.Drawing.Point(440, 24);
            this.turnsLabel.Name = "turnsLabel";
            this.turnsLabel.Size = new System.Drawing.Size(42, 15);
            this.turnsLabel.TabIndex = 3;
            this.turnsLabel.Text = "Turns :";
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(427, 73);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(82, 15);
            this.elapsedTimeLabel.TabIndex = 4;
            this.elapsedTimeLabel.Text = "Elapsed Time :";
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
            this.ExitButton.Location = new System.Drawing.Point(434, 377);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 412);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.displayTimerLabel);
            this.Controls.Add(this.turnsCountLabel);
            this.Controls.Add(this.elapsedTimeLabel);
            this.Controls.Add(this.turnsLabel);
            this.Controls.Add(this.gameBoardPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label turnsLabel;
        private Label elapsedTimeLabel;
        private Label turnsCountLabel;
        private Label displayTimerLabel;
        private Button ExitButton;
    }
}