
namespace ChessGUI
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
            this.ChessPieceSelectLabel = new System.Windows.Forms.Label();
            this.ChessPieceComboBox = new System.Windows.Forms.ComboBox();
            this.ChessBoardPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ChessPieceSelectLabel
            // 
            this.ChessPieceSelectLabel.AutoSize = true;
            this.ChessPieceSelectLabel.BackColor = System.Drawing.Color.Black;
            this.ChessPieceSelectLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChessPieceSelectLabel.ForeColor = System.Drawing.Color.White;
            this.ChessPieceSelectLabel.Location = new System.Drawing.Point(12, 18);
            this.ChessPieceSelectLabel.Name = "ChessPieceSelectLabel";
            this.ChessPieceSelectLabel.Size = new System.Drawing.Size(475, 15);
            this.ChessPieceSelectLabel.TabIndex = 0;
            this.ChessPieceSelectLabel.Text = "Select a type of chess piece and then click on the grid. I will show you all lega" +
    "l moves";
            // 
            // ChessPieceComboBox
            // 
            this.ChessPieceComboBox.BackColor = System.Drawing.Color.Silver;
            this.ChessPieceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChessPieceComboBox.FormattingEnabled = true;
            this.ChessPieceComboBox.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Knight",
            "Rook",
            "Bishop"});
            this.ChessPieceComboBox.Location = new System.Drawing.Point(493, 15);
            this.ChessPieceComboBox.Name = "ChessPieceComboBox";
            this.ChessPieceComboBox.Size = new System.Drawing.Size(121, 23);
            this.ChessPieceComboBox.TabIndex = 1;
            // 
            // ChessBoardPanel
            // 
            this.ChessBoardPanel.BackColor = System.Drawing.Color.Silver;
            this.ChessBoardPanel.Location = new System.Drawing.Point(63, 55);
            this.ChessBoardPanel.Name = "ChessBoardPanel";
            this.ChessBoardPanel.Size = new System.Drawing.Size(500, 500);
            this.ChessBoardPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChessGUI.Properties.Resources.chess;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 577);
            this.Controls.Add(this.ChessBoardPanel);
            this.Controls.Add(this.ChessPieceComboBox);
            this.Controls.Add(this.ChessPieceSelectLabel);
            this.Name = "Form1";
            this.Text = "Chess Legal Moves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChessPieceSelectLabel;
        private System.Windows.Forms.ComboBox ChessPieceComboBox;
        private System.Windows.Forms.Panel ChessBoardPanel;
    }
}

