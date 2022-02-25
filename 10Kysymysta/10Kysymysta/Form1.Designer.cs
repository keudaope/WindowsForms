namespace _10Kysymysta
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
            this.KysymysLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DRB = new System.Windows.Forms.RadioButton();
            this.CRB = new System.Windows.Forms.RadioButton();
            this.BRB = new System.Windows.Forms.RadioButton();
            this.ARB = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.VastausLb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLb
            // 
            this.KysymysLb.AutoSize = true;
            this.KysymysLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KysymysLb.Location = new System.Drawing.Point(18, 22);
            this.KysymysLb.Name = "KysymysLb";
            this.KysymysLb.Size = new System.Drawing.Size(279, 25);
            this.KysymysLb.TabIndex = 0;
            this.KysymysLb.Text = "Vastaus 1. kysymykseen:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DRB);
            this.groupBox1.Controls.Add(this.CRB);
            this.groupBox1.Controls.Add(this.BRB);
            this.groupBox1.Controls.Add(this.ARB);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(309, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(77, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vastaus";
            // 
            // DRB
            // 
            this.DRB.AutoSize = true;
            this.DRB.Location = new System.Drawing.Point(17, 104);
            this.DRB.Name = "DRB";
            this.DRB.Size = new System.Drawing.Size(33, 17);
            this.DRB.TabIndex = 4;
            this.DRB.TabStop = true;
            this.DRB.Text = "D";
            this.DRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            this.CRB.AutoSize = true;
            this.CRB.Location = new System.Drawing.Point(17, 80);
            this.CRB.Name = "CRB";
            this.CRB.Size = new System.Drawing.Size(32, 17);
            this.CRB.TabIndex = 3;
            this.CRB.TabStop = true;
            this.CRB.Text = "C";
            this.CRB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            this.BRB.AutoSize = true;
            this.BRB.Location = new System.Drawing.Point(17, 56);
            this.BRB.Name = "BRB";
            this.BRB.Size = new System.Drawing.Size(32, 17);
            this.BRB.TabIndex = 2;
            this.BRB.TabStop = true;
            this.BRB.Text = "B";
            this.BRB.UseVisualStyleBackColor = true;
            // 
            // ARB
            // 
            this.ARB.AutoSize = true;
            this.ARB.Location = new System.Drawing.Point(17, 33);
            this.ARB.Name = "ARB";
            this.ARB.Size = new System.Drawing.Size(32, 17);
            this.ARB.TabIndex = 1;
            this.ARB.TabStop = true;
            this.ARB.Text = "A";
            this.ARB.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // VastausLb
            // 
            this.VastausLb.AutoSize = true;
            this.VastausLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLb.Location = new System.Drawing.Point(18, 134);
            this.VastausLb.Name = "VastausLb";
            this.VastausLb.Size = new System.Drawing.Size(0, 25);
            this.VastausLb.TabIndex = 2;
            this.VastausLb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 167);
            this.Controls.Add(this.VastausLb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KysymysLb);
            this.Name = "Form1";
            this.Text = "10 Kysymystä";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DRB;
        private System.Windows.Forms.RadioButton CRB;
        private System.Windows.Forms.RadioButton BRB;
        private System.Windows.Forms.RadioButton ARB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label VastausLb;
    }
}

