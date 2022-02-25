namespace graafinen
{
    partial class Form2
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
            this.SyöttöOtsikkoLB = new System.Windows.Forms.Label();
            this.PvmLB = new System.Windows.Forms.Label();
            this.PaivaysDP = new System.Windows.Forms.DateTimePicker();
            this.RahastoLB = new System.Windows.Forms.Label();
            this.RahastoCB = new System.Windows.Forms.ComboBox();
            this.KurssiLB = new System.Windows.Forms.Label();
            this.KurssiTB = new System.Windows.Forms.TextBox();
            this.TallennaBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyöttöOtsikkoLB
            // 
            this.SyöttöOtsikkoLB.AutoSize = true;
            this.SyöttöOtsikkoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyöttöOtsikkoLB.Location = new System.Drawing.Point(13, 13);
            this.SyöttöOtsikkoLB.Name = "SyöttöOtsikkoLB";
            this.SyöttöOtsikkoLB.Size = new System.Drawing.Size(555, 25);
            this.SyöttöOtsikkoLB.TabIndex = 0;
            this.SyöttöOtsikkoLB.Text = "Tämän lomakkeen avulla voit syöttää tietoja tietokantaan";
            // 
            // PvmLB
            // 
            this.PvmLB.AutoSize = true;
            this.PvmLB.Location = new System.Drawing.Point(15, 60);
            this.PvmLB.Name = "PvmLB";
            this.PvmLB.Size = new System.Drawing.Size(50, 13);
            this.PvmLB.TabIndex = 1;
            this.PvmLB.Text = "Päiväys: ";
            // 
            // PaivaysDP
            // 
            this.PaivaysDP.Location = new System.Drawing.Point(74, 56);
            this.PaivaysDP.Name = "PaivaysDP";
            this.PaivaysDP.Size = new System.Drawing.Size(200, 20);
            this.PaivaysDP.TabIndex = 2;
            // 
            // RahastoLB
            // 
            this.RahastoLB.AutoSize = true;
            this.RahastoLB.Location = new System.Drawing.Point(15, 90);
            this.RahastoLB.Name = "RahastoLB";
            this.RahastoLB.Size = new System.Drawing.Size(50, 13);
            this.RahastoLB.TabIndex = 3;
            this.RahastoLB.Text = "Rahasto:";
            // 
            // RahastoCB
            // 
            this.RahastoCB.FormattingEnabled = true;
            this.RahastoCB.Location = new System.Drawing.Point(74, 86);
            this.RahastoCB.Name = "RahastoCB";
            this.RahastoCB.Size = new System.Drawing.Size(200, 21);
            this.RahastoCB.TabIndex = 4;
            this.RahastoCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // KurssiLB
            // 
            this.KurssiLB.AutoSize = true;
            this.KurssiLB.Location = new System.Drawing.Point(18, 124);
            this.KurssiLB.Name = "KurssiLB";
            this.KurssiLB.Size = new System.Drawing.Size(38, 13);
            this.KurssiLB.TabIndex = 5;
            this.KurssiLB.Text = "Kurssi:";
            // 
            // KurssiTB
            // 
            this.KurssiTB.Location = new System.Drawing.Point(74, 120);
            this.KurssiTB.Name = "KurssiTB";
            this.KurssiTB.Size = new System.Drawing.Size(200, 20);
            this.KurssiTB.TabIndex = 6;
            // 
            // TallennaBt
            // 
            this.TallennaBt.Location = new System.Drawing.Point(197, 147);
            this.TallennaBt.Name = "TallennaBt";
            this.TallennaBt.Size = new System.Drawing.Size(75, 23);
            this.TallennaBt.TabIndex = 7;
            this.TallennaBt.Text = "Tallenna";
            this.TallennaBt.UseVisualStyleBackColor = true;
            this.TallennaBt.Click += new System.EventHandler(this.TallennaBt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TallennaBt);
            this.Controls.Add(this.KurssiTB);
            this.Controls.Add(this.KurssiLB);
            this.Controls.Add(this.RahastoCB);
            this.Controls.Add(this.RahastoLB);
            this.Controls.Add(this.PaivaysDP);
            this.Controls.Add(this.PvmLB);
            this.Controls.Add(this.SyöttöOtsikkoLB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SyöttöOtsikkoLB;
        private System.Windows.Forms.Label PvmLB;
        private System.Windows.Forms.DateTimePicker PaivaysDP;
        private System.Windows.Forms.Label RahastoLB;
        private System.Windows.Forms.ComboBox RahastoCB;
        private System.Windows.Forms.Label KurssiLB;
        private System.Windows.Forms.TextBox KurssiTB;
        private System.Windows.Forms.Button TallennaBt;
    }
}