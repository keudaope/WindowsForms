namespace EncryptDecrypt
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
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.EncTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DecTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DecPainike = new System.Windows.Forms.Button();
            this.EncPainike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salasana";
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(168, 74);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(557, 32);
            this.SalasanaTB.TabIndex = 1;
            // 
            // EncTB
            // 
            this.EncTB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncTB.Location = new System.Drawing.Point(168, 141);
            this.EncTB.Name = "EncTB";
            this.EncTB.Size = new System.Drawing.Size(557, 32);
            this.EncTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypt:";
            // 
            // DecTB
            // 
            this.DecTB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecTB.Location = new System.Drawing.Point(168, 218);
            this.DecTB.Name = "DecTB";
            this.DecTB.Size = new System.Drawing.Size(557, 32);
            this.DecTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decrypt:";
            // 
            // DecPainike
            // 
            this.DecPainike.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecPainike.Location = new System.Drawing.Point(613, 291);
            this.DecPainike.Name = "DecPainike";
            this.DecPainike.Size = new System.Drawing.Size(112, 39);
            this.DecPainike.TabIndex = 6;
            this.DecPainike.Text = "Decrypt";
            this.DecPainike.UseVisualStyleBackColor = true;
            this.DecPainike.Click += new System.EventHandler(this.DecPainike_Click);
            // 
            // EncPainike
            // 
            this.EncPainike.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncPainike.Location = new System.Drawing.Point(477, 291);
            this.EncPainike.Name = "EncPainike";
            this.EncPainike.Size = new System.Drawing.Size(112, 39);
            this.EncPainike.TabIndex = 7;
            this.EncPainike.Text = "Encrypt";
            this.EncPainike.UseVisualStyleBackColor = true;
            this.EncPainike.Click += new System.EventHandler(this.EncPainike_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EncPainike);
            this.Controls.Add(this.DecPainike);
            this.Controls.Add(this.DecTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EncTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox EncTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DecTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DecPainike;
        private System.Windows.Forms.Button EncPainike;
    }
}

