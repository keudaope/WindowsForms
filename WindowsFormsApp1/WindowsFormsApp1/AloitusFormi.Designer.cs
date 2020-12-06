namespace WindowsFormsApp1
{
    partial class AloitusFormi
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
            this.MitaLabel = new System.Windows.Forms.Label();
            this.UusiTiliButton = new System.Windows.Forms.Button();
            this.TallettaaButton = new System.Windows.Forms.Button();
            this.NostaaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MitaLabel
            // 
            this.MitaLabel.AutoSize = true;
            this.MitaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MitaLabel.Location = new System.Drawing.Point(27, 28);
            this.MitaLabel.Name = "MitaLabel";
            this.MitaLabel.Size = new System.Drawing.Size(419, 55);
            this.MitaLabel.TabIndex = 0;
            this.MitaLabel.Text = "Mitä haluat tehdä?";
            // 
            // UusiTiliButton
            // 
            this.UusiTiliButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiTiliButton.Location = new System.Drawing.Point(37, 117);
            this.UusiTiliButton.Name = "UusiTiliButton";
            this.UusiTiliButton.Size = new System.Drawing.Size(389, 102);
            this.UusiTiliButton.TabIndex = 1;
            this.UusiTiliButton.Text = "Syöttää uuden tilin";
            this.UusiTiliButton.UseVisualStyleBackColor = true;
            this.UusiTiliButton.Click += new System.EventHandler(this.UusiTiliButton_Click);
            // 
            // TallettaaButton
            // 
            this.TallettaaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallettaaButton.Location = new System.Drawing.Point(37, 245);
            this.TallettaaButton.Name = "TallettaaButton";
            this.TallettaaButton.Size = new System.Drawing.Size(389, 102);
            this.TallettaaButton.TabIndex = 2;
            this.TallettaaButton.Text = "Tallettaa rahaa";
            this.TallettaaButton.UseVisualStyleBackColor = true;
            // 
            // NostaaButton
            // 
            this.NostaaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NostaaButton.Location = new System.Drawing.Point(37, 380);
            this.NostaaButton.Name = "NostaaButton";
            this.NostaaButton.Size = new System.Drawing.Size(389, 102);
            this.NostaaButton.TabIndex = 3;
            this.NostaaButton.Text = "Nostaa rahaa";
            this.NostaaButton.UseVisualStyleBackColor = true;
            // 
            // AloitusFormi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 564);
            this.Controls.Add(this.NostaaButton);
            this.Controls.Add(this.TallettaaButton);
            this.Controls.Add(this.UusiTiliButton);
            this.Controls.Add(this.MitaLabel);
            this.Name = "AloitusFormi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MitaLabel;
        private System.Windows.Forms.Button UusiTiliButton;
        private System.Windows.Forms.Button TallettaaButton;
        private System.Windows.Forms.Button NostaaButton;
    }
}

