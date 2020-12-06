namespace WindowsFormsApp1
{
    partial class TalletusFormi
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
            this.OmistajaLabel = new System.Windows.Forms.Label();
            this.TilinumeroLabel = new System.Windows.Forms.Label();
            this.SaldoLabel = new System.Windows.Forms.Label();
            this.OmistajaTextBox = new System.Windows.Forms.TextBox();
            this.TilinroTextBox = new System.Windows.Forms.TextBox();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.UusiTiliButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OmistajaLabel
            // 
            this.OmistajaLabel.AutoSize = true;
            this.OmistajaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OmistajaLabel.Location = new System.Drawing.Point(22, 43);
            this.OmistajaLabel.Name = "OmistajaLabel";
            this.OmistajaLabel.Size = new System.Drawing.Size(144, 37);
            this.OmistajaLabel.TabIndex = 0;
            this.OmistajaLabel.Text = "Omistaja";
            // 
            // TilinumeroLabel
            // 
            this.TilinumeroLabel.AutoSize = true;
            this.TilinumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TilinumeroLabel.Location = new System.Drawing.Point(22, 118);
            this.TilinumeroLabel.Name = "TilinumeroLabel";
            this.TilinumeroLabel.Size = new System.Drawing.Size(167, 37);
            this.TilinumeroLabel.TabIndex = 1;
            this.TilinumeroLabel.Text = "Tilinumero";
            // 
            // SaldoLabel
            // 
            this.SaldoLabel.AutoSize = true;
            this.SaldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldoLabel.Location = new System.Drawing.Point(22, 190);
            this.SaldoLabel.Name = "SaldoLabel";
            this.SaldoLabel.Size = new System.Drawing.Size(99, 37);
            this.SaldoLabel.TabIndex = 2;
            this.SaldoLabel.Text = "Saldo";
            // 
            // OmistajaTextBox
            // 
            this.OmistajaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OmistajaTextBox.Location = new System.Drawing.Point(210, 43);
            this.OmistajaTextBox.Name = "OmistajaTextBox";
            this.OmistajaTextBox.Size = new System.Drawing.Size(260, 44);
            this.OmistajaTextBox.TabIndex = 3;
            // 
            // TilinroTextBox
            // 
            this.TilinroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TilinroTextBox.Location = new System.Drawing.Point(210, 118);
            this.TilinroTextBox.Name = "TilinroTextBox";
            this.TilinroTextBox.Size = new System.Drawing.Size(260, 44);
            this.TilinroTextBox.TabIndex = 4;
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldoTextBox.Location = new System.Drawing.Point(210, 190);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.Size = new System.Drawing.Size(260, 44);
            this.SaldoTextBox.TabIndex = 5;
            // 
            // UusiTiliButton
            // 
            this.UusiTiliButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiTiliButton.Location = new System.Drawing.Point(210, 278);
            this.UusiTiliButton.Name = "UusiTiliButton";
            this.UusiTiliButton.Size = new System.Drawing.Size(260, 58);
            this.UusiTiliButton.TabIndex = 6;
            this.UusiTiliButton.Text = "Tallenna uusi tili";
            this.UusiTiliButton.UseVisualStyleBackColor = true;
            this.UusiTiliButton.Click += new System.EventHandler(this.UusiTiliButton_Click);
            // 
            // TalletusFormi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 564);
            this.Controls.Add(this.UusiTiliButton);
            this.Controls.Add(this.SaldoTextBox);
            this.Controls.Add(this.TilinroTextBox);
            this.Controls.Add(this.OmistajaTextBox);
            this.Controls.Add(this.SaldoLabel);
            this.Controls.Add(this.TilinumeroLabel);
            this.Controls.Add(this.OmistajaLabel);
            this.Name = "TalletusFormi";
            this.Text = "TalletusFormi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OmistajaLabel;
        private System.Windows.Forms.Label TilinumeroLabel;
        private System.Windows.Forms.Label SaldoLabel;
        private System.Windows.Forms.TextBox OmistajaTextBox;
        private System.Windows.Forms.TextBox TilinroTextBox;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Button UusiTiliButton;
    }
}