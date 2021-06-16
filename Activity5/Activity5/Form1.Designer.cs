/* * * * * * * * * * * *
 * Warren Peterson * * *
 * This is my own work *
 * CST-227 6/16/2021 * *
 *  Activity 5 * * * * *
 * WACK-A-MOLE * * * * *
 * * * * * * * * * * * */
namespace Activity5
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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playAgainButton = new System.Windows.Forms.Button();
            this.MissButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.FalseTargetPictureBox = new System.Windows.Forms.PictureBox();
            this.TargetPictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreNumberLabel = new System.Windows.Forms.Label();
            this.FalseTargetPictureBox1 = new System.Windows.Forms.PictureBox();
            this.FalseTargetPictureBox2 = new System.Windows.Forms.PictureBox();
            this.FalseTargetPictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FalseTargetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FalseTargetPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FalseTargetPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FalseTargetPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(29, 397);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(137, 397);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(247, 397);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(358, 397);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(75, 23);
            this.playAgainButton.TabIndex = 5;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // MissButton
            // 
            this.MissButton.BackgroundImage = global::Activity5.Properties.Resources.purple_background;
            this.MissButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MissButton.Location = new System.Drawing.Point(-10, -14);
            this.MissButton.Name = "MissButton";
            this.MissButton.Size = new System.Drawing.Size(814, 470);
            this.MissButton.TabIndex = 6;
            this.MissButton.UseVisualStyleBackColor = true;
            this.MissButton.Click += new System.EventHandler(this.MissButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(13, 28);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(45, 15);
            this.ScoreLabel.TabIndex = 7;
            this.ScoreLabel.Text = "Score : ";
            // 
            // FalseTargetPictureBox
            // 
            this.FalseTargetPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FalseTargetPictureBox.ErrorImage = global::Activity5.Properties.Resources.redX;
            this.FalseTargetPictureBox.Image = global::Activity5.Properties.Resources.redX;
            this.FalseTargetPictureBox.Location = new System.Drawing.Point(12, 145);
            this.FalseTargetPictureBox.Name = "FalseTargetPictureBox";
            this.FalseTargetPictureBox.Size = new System.Drawing.Size(58, 52);
            this.FalseTargetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FalseTargetPictureBox.TabIndex = 8;
            this.FalseTargetPictureBox.TabStop = false;
            this.FalseTargetPictureBox.Click += new System.EventHandler(this.FalseTargetPictureBox_Click);
            // 
            // TargetPictureBox
            // 
            this.TargetPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TargetPictureBox.ErrorImage = global::Activity5.Properties.Resources.mole;
            this.TargetPictureBox.Image = global::Activity5.Properties.Resources.mole;
            this.TargetPictureBox.Location = new System.Drawing.Point(12, 87);
            this.TargetPictureBox.Name = "TargetPictureBox";
            this.TargetPictureBox.Size = new System.Drawing.Size(58, 52);
            this.TargetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TargetPictureBox.TabIndex = 9;
            this.TargetPictureBox.TabStop = false;
            this.TargetPictureBox.Click += new System.EventHandler(this.TargetPictureBox_Click);
            // 
            // ScoreNumberLabel
            // 
            this.ScoreNumberLabel.AutoSize = true;
            this.ScoreNumberLabel.Location = new System.Drawing.Point(57, 28);
            this.ScoreNumberLabel.Name = "ScoreNumberLabel";
            this.ScoreNumberLabel.Size = new System.Drawing.Size(13, 15);
            this.ScoreNumberLabel.TabIndex = 10;
            this.ScoreNumberLabel.Text = "0";
            // 
            // FalseTargetPictureBox1
            // 
            this.FalseTargetPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FalseTargetPictureBox1.ErrorImage = global::Activity5.Properties.Resources.redX;
            this.FalseTargetPictureBox1.Image = global::Activity5.Properties.Resources.redX;
            this.FalseTargetPictureBox1.Location = new System.Drawing.Point(12, 203);
            this.FalseTargetPictureBox1.Name = "FalseTargetPictureBox1";
            this.FalseTargetPictureBox1.Size = new System.Drawing.Size(58, 52);
            this.FalseTargetPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FalseTargetPictureBox1.TabIndex = 11;
            this.FalseTargetPictureBox1.TabStop = false;
            this.FalseTargetPictureBox1.Click += new System.EventHandler(this.FalseTargetPictureBox1_Click);
            // 
            // FalseTargetPictureBox2
            // 
            this.FalseTargetPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FalseTargetPictureBox2.ErrorImage = global::Activity5.Properties.Resources.redX;
            this.FalseTargetPictureBox2.Image = global::Activity5.Properties.Resources.redX;
            this.FalseTargetPictureBox2.Location = new System.Drawing.Point(12, 261);
            this.FalseTargetPictureBox2.Name = "FalseTargetPictureBox2";
            this.FalseTargetPictureBox2.Size = new System.Drawing.Size(58, 52);
            this.FalseTargetPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FalseTargetPictureBox2.TabIndex = 12;
            this.FalseTargetPictureBox2.TabStop = false;
            this.FalseTargetPictureBox2.Click += new System.EventHandler(this.FalseTargetPictureBox2_Click);
            // 
            // FalseTargetPictureBox3
            // 
            this.FalseTargetPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FalseTargetPictureBox3.ErrorImage = global::Activity5.Properties.Resources.redX;
            this.FalseTargetPictureBox3.Image = global::Activity5.Properties.Resources.redX;
            this.FalseTargetPictureBox3.Location = new System.Drawing.Point(13, 319);
            this.FalseTargetPictureBox3.Name = "FalseTargetPictureBox3";
            this.FalseTargetPictureBox3.Size = new System.Drawing.Size(58, 52);
            this.FalseTargetPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FalseTargetPictureBox3.TabIndex = 13;
            this.FalseTargetPictureBox3.TabStop = false;
            this.FalseTargetPictureBox3.Click += new System.EventHandler(this.FalseTargetPictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FalseTargetPictureBox3);
            this.Controls.Add(this.FalseTargetPictureBox2);
            this.Controls.Add(this.FalseTargetPictureBox1);
            this.Controls.Add(this.ScoreNumberLabel);
            this.Controls.Add(this.TargetPictureBox);
            this.Controls.Add(this.FalseTargetPictureBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.MissButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Wack A Mole";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FalseTargetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FalseTargetPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FalseTargetPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FalseTargetPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button MissButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox FalseTargetPictureBox;
        private System.Windows.Forms.PictureBox TargetPictureBox;
        private System.Windows.Forms.Label ScoreNumberLabel;
        private System.Windows.Forms.PictureBox FalseTargetPictureBox1;
        private System.Windows.Forms.PictureBox FalseTargetPictureBox2;
        private System.Windows.Forms.PictureBox FalseTargetPictureBox3;
    }
}

