namespace Hotellivarausja
{
    partial class VaraustenHallinta
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
            this.UlosLB = new System.Windows.Forms.Label();
            this.TyhjennaVarausPainike = new System.Windows.Forms.Button();
            this.PoistaVarausPainike = new System.Windows.Forms.Button();
            this.MuokkaaVaraustaPainike = new System.Windows.Forms.Button();
            this.UusiVarausPainike = new System.Windows.Forms.Button();
            this.VarauksetDG = new System.Windows.Forms.DataGridView();
            this.SisaanLB = new System.Windows.Forms.Label();
            this.HuoneenNroLB = new System.Windows.Forms.Label();
            this.HuonetyyppiLB = new System.Windows.Forms.Label();
            this.AsiakasNroLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AsiakasCB = new System.Windows.Forms.ComboBox();
            this.UlosDTP = new System.Windows.Forms.DateTimePicker();
            this.SisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.HuoneNroCB = new System.Windows.Forms.ComboBox();
            this.HuonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.VarausNroLB = new System.Windows.Forms.Label();
            this.VarausNroTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(967, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UlosLB
            // 
            this.UlosLB.AutoSize = true;
            this.UlosLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlosLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.UlosLB.Location = new System.Drawing.Point(142, 298);
            this.UlosLB.Name = "UlosLB";
            this.UlosLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UlosLB.Size = new System.Drawing.Size(65, 27);
            this.UlosLB.TabIndex = 16;
            this.UlosLB.Text = "Ulos:";
            // 
            // TyhjennaVarausPainike
            // 
            this.TyhjennaVarausPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaVarausPainike.Location = new System.Drawing.Point(275, 374);
            this.TyhjennaVarausPainike.Name = "TyhjennaVarausPainike";
            this.TyhjennaVarausPainike.Size = new System.Drawing.Size(128, 29);
            this.TyhjennaVarausPainike.TabIndex = 15;
            this.TyhjennaVarausPainike.Text = "Tyhjennä kentät";
            this.TyhjennaVarausPainike.UseVisualStyleBackColor = true;
            // 
            // PoistaVarausPainike
            // 
            this.PoistaVarausPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaVarausPainike.Location = new System.Drawing.Point(342, 339);
            this.PoistaVarausPainike.Name = "PoistaVarausPainike";
            this.PoistaVarausPainike.Size = new System.Drawing.Size(62, 29);
            this.PoistaVarausPainike.TabIndex = 14;
            this.PoistaVarausPainike.Text = "Poista";
            this.PoistaVarausPainike.UseVisualStyleBackColor = true;
            this.PoistaVarausPainike.Click += new System.EventHandler(this.PoistaVarausPainike_Click);
            // 
            // MuokkaaVaraustaPainike
            // 
            this.MuokkaaVaraustaPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuokkaaVaraustaPainike.Location = new System.Drawing.Point(253, 339);
            this.MuokkaaVaraustaPainike.Name = "MuokkaaVaraustaPainike";
            this.MuokkaaVaraustaPainike.Size = new System.Drawing.Size(83, 29);
            this.MuokkaaVaraustaPainike.TabIndex = 13;
            this.MuokkaaVaraustaPainike.Text = "Muokkaa";
            this.MuokkaaVaraustaPainike.UseVisualStyleBackColor = true;
            this.MuokkaaVaraustaPainike.Click += new System.EventHandler(this.MuokkaaVaraustaPainike_Click);
            // 
            // UusiVarausPainike
            // 
            this.UusiVarausPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiVarausPainike.Location = new System.Drawing.Point(94, 339);
            this.UusiVarausPainike.Name = "UusiVarausPainike";
            this.UusiVarausPainike.Size = new System.Drawing.Size(153, 29);
            this.UusiVarausPainike.TabIndex = 12;
            this.UusiVarausPainike.Text = "Lisää uusi varaus";
            this.UusiVarausPainike.UseVisualStyleBackColor = true;
            this.UusiVarausPainike.Click += new System.EventHandler(this.UusiVarausPainike_Click);
            // 
            // VarauksetDG
            // 
            this.VarauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VarauksetDG.Location = new System.Drawing.Point(422, 116);
            this.VarauksetDG.Name = "VarauksetDG";
            this.VarauksetDG.Size = new System.Drawing.Size(545, 331);
            this.VarauksetDG.TabIndex = 11;
            this.VarauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellClick);
            this.VarauksetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellContentClick);
            // 
            // SisaanLB
            // 
            this.SisaanLB.AutoSize = true;
            this.SisaanLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisaanLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.SisaanLB.Location = new System.Drawing.Point(118, 263);
            this.SisaanLB.Name = "SisaanLB";
            this.SisaanLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SisaanLB.Size = new System.Drawing.Size(89, 27);
            this.SisaanLB.TabIndex = 9;
            this.SisaanLB.Text = "Sisään:";
            // 
            // HuoneenNroLB
            // 
            this.HuoneenNroLB.AutoSize = true;
            this.HuoneenNroLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneenNroLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.HuoneenNroLB.Location = new System.Drawing.Point(55, 228);
            this.HuoneenNroLB.Name = "HuoneenNroLB";
            this.HuoneenNroLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HuoneenNroLB.Size = new System.Drawing.Size(152, 27);
            this.HuoneenNroLB.TabIndex = 7;
            this.HuoneenNroLB.Text = "Huoneen nro:";
            // 
            // HuonetyyppiLB
            // 
            this.HuonetyyppiLB.AutoSize = true;
            this.HuonetyyppiLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuonetyyppiLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.HuonetyyppiLB.Location = new System.Drawing.Point(51, 193);
            this.HuonetyyppiLB.Name = "HuonetyyppiLB";
            this.HuonetyyppiLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HuonetyyppiLB.Size = new System.Drawing.Size(156, 27);
            this.HuonetyyppiLB.TabIndex = 5;
            this.HuonetyyppiLB.Text = "Huonetyyppi: ";
            // 
            // AsiakasNroLB
            // 
            this.AsiakasNroLB.AutoSize = true;
            this.AsiakasNroLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasNroLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.AsiakasNroLB.Location = new System.Drawing.Point(65, 157);
            this.AsiakasNroLB.Name = "AsiakasNroLB";
            this.AsiakasNroLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AsiakasNroLB.Size = new System.Drawing.Size(142, 27);
            this.AsiakasNroLB.TabIndex = 1;
            this.AsiakasNroLB.Text = "Asiakas nro:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 81);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.VarausNroTB);
            this.panel1.Controls.Add(this.VarausNroLB);
            this.panel1.Controls.Add(this.AsiakasCB);
            this.panel1.Controls.Add(this.UlosDTP);
            this.panel1.Controls.Add(this.SisaanDTP);
            this.panel1.Controls.Add(this.HuoneNroCB);
            this.panel1.Controls.Add(this.HuonetyyppiCB);
            this.panel1.Controls.Add(this.UlosLB);
            this.panel1.Controls.Add(this.TyhjennaVarausPainike);
            this.panel1.Controls.Add(this.PoistaVarausPainike);
            this.panel1.Controls.Add(this.MuokkaaVaraustaPainike);
            this.panel1.Controls.Add(this.UusiVarausPainike);
            this.panel1.Controls.Add(this.VarauksetDG);
            this.panel1.Controls.Add(this.SisaanLB);
            this.panel1.Controls.Add(this.HuoneenNroLB);
            this.panel1.Controls.Add(this.HuonetyyppiLB);
            this.panel1.Controls.Add(this.AsiakasNroLB);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 454);
            this.panel1.TabIndex = 1;
            // 
            // AsiakasCB
            // 
            this.AsiakasCB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasCB.FormattingEnabled = true;
            this.AsiakasCB.Location = new System.Drawing.Point(214, 157);
            this.AsiakasCB.Name = "AsiakasCB";
            this.AsiakasCB.Size = new System.Drawing.Size(190, 30);
            this.AsiakasCB.TabIndex = 22;
            // 
            // UlosDTP
            // 
            this.UlosDTP.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlosDTP.CustomFormat = "dd.MM.yyyy";
            this.UlosDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlosDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UlosDTP.Location = new System.Drawing.Point(213, 302);
            this.UlosDTP.Name = "UlosDTP";
            this.UlosDTP.Size = new System.Drawing.Size(190, 29);
            this.UlosDTP.TabIndex = 21;
            // 
            // SisaanDTP
            // 
            this.SisaanDTP.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisaanDTP.CustomFormat = "dd.MM.yyyy";
            this.SisaanDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisaanDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SisaanDTP.Location = new System.Drawing.Point(214, 264);
            this.SisaanDTP.Name = "SisaanDTP";
            this.SisaanDTP.Size = new System.Drawing.Size(190, 29);
            this.SisaanDTP.TabIndex = 20;
            // 
            // HuoneNroCB
            // 
            this.HuoneNroCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuoneNroCB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneNroCB.FormattingEnabled = true;
            this.HuoneNroCB.Location = new System.Drawing.Point(213, 227);
            this.HuoneNroCB.Name = "HuoneNroCB";
            this.HuoneNroCB.Size = new System.Drawing.Size(190, 30);
            this.HuoneNroCB.TabIndex = 19;
            // 
            // HuonetyyppiCB
            // 
            this.HuonetyyppiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuonetyyppiCB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuonetyyppiCB.FormattingEnabled = true;
            this.HuonetyyppiCB.Location = new System.Drawing.Point(214, 193);
            this.HuonetyyppiCB.Name = "HuonetyyppiCB";
            this.HuonetyyppiCB.Size = new System.Drawing.Size(190, 30);
            this.HuonetyyppiCB.TabIndex = 18;
            this.HuonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.HuonetyyppiCB_SelectedIndexChanged);
            // 
            // VarausNroLB
            // 
            this.VarausNroLB.AutoSize = true;
            this.VarausNroLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausNroLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.VarausNroLB.Location = new System.Drawing.Point(65, 120);
            this.VarausNroLB.Name = "VarausNroLB";
            this.VarausNroLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VarausNroLB.Size = new System.Drawing.Size(131, 27);
            this.VarausNroLB.TabIndex = 23;
            this.VarausNroLB.Text = "Varaus nro:";
            // 
            // VarausNroTB
            // 
            this.VarausNroTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausNroTB.Location = new System.Drawing.Point(214, 121);
            this.VarausNroTB.Name = "VarausNroTB";
            this.VarausNroTB.Size = new System.Drawing.Size(190, 29);
            this.VarausNroTB.TabIndex = 24;
            // 
            // VaraustenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 454);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VaraustenHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VaraustenHallinta";
            this.Load += new System.EventHandler(this.VaraustenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UlosLB;
        private System.Windows.Forms.Button TyhjennaVarausPainike;
        private System.Windows.Forms.Button PoistaVarausPainike;
        private System.Windows.Forms.Button MuokkaaVaraustaPainike;
        private System.Windows.Forms.Button UusiVarausPainike;
        private System.Windows.Forms.DataGridView VarauksetDG;
        private System.Windows.Forms.Label SisaanLB;
        private System.Windows.Forms.Label HuoneenNroLB;
        private System.Windows.Forms.Label HuonetyyppiLB;
        private System.Windows.Forms.Label AsiakasNroLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker UlosDTP;
        private System.Windows.Forms.DateTimePicker SisaanDTP;
        private System.Windows.Forms.ComboBox HuoneNroCB;
        private System.Windows.Forms.ComboBox HuonetyyppiCB;
        private System.Windows.Forms.ComboBox AsiakasCB;
        private System.Windows.Forms.Label VarausNroLB;
        private System.Windows.Forms.TextBox VarausNroTB;
    }
}