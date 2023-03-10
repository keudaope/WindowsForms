namespace Hotellivarausja
{
    partial class HuoneidenHallinta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TyhjennaHuonePainike = new System.Windows.Forms.Button();
            this.PoistaHuonePainike = new System.Windows.Forms.Button();
            this.MuokkaaHuonePainike = new System.Windows.Forms.Button();
            this.UusiHuonePainike = new System.Windows.Forms.Button();
            this.HuoneetDG = new System.Windows.Forms.DataGridView();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.HuoneTyyppiLB = new System.Windows.Forms.Label();
            this.HuoneenNroTB = new System.Windows.Forms.TextBox();
            this.EtunimiLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HuonePaneeli = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EiRB = new System.Windows.Forms.RadioButton();
            this.KyllaRB = new System.Windows.Forms.RadioButton();
            this.HuonetyyppiCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).BeginInit();
            this.panel2.SuspendLayout();
            this.HuonePaneeli.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(967, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huoneiden hallinta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TyhjennaHuonePainike
            // 
            this.TyhjennaHuonePainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TyhjennaHuonePainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaHuonePainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.TyhjennaHuonePainike.Location = new System.Drawing.Point(273, 309);
            this.TyhjennaHuonePainike.Name = "TyhjennaHuonePainike";
            this.TyhjennaHuonePainike.Size = new System.Drawing.Size(128, 29);
            this.TyhjennaHuonePainike.TabIndex = 15;
            this.TyhjennaHuonePainike.Text = "Tyhjennä kentät";
            this.TyhjennaHuonePainike.UseVisualStyleBackColor = false;
            this.TyhjennaHuonePainike.Click += new System.EventHandler(this.TyhjennaHuonePainike_Click);
            // 
            // PoistaHuonePainike
            // 
            this.PoistaHuonePainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PoistaHuonePainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaHuonePainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.PoistaHuonePainike.Location = new System.Drawing.Point(340, 274);
            this.PoistaHuonePainike.Name = "PoistaHuonePainike";
            this.PoistaHuonePainike.Size = new System.Drawing.Size(62, 29);
            this.PoistaHuonePainike.TabIndex = 14;
            this.PoistaHuonePainike.Text = "Poista";
            this.PoistaHuonePainike.UseVisualStyleBackColor = false;
            this.PoistaHuonePainike.Click += new System.EventHandler(this.PoistaHuonePainike_Click);
            // 
            // MuokkaaHuonePainike
            // 
            this.MuokkaaHuonePainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MuokkaaHuonePainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuokkaaHuonePainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.MuokkaaHuonePainike.Location = new System.Drawing.Point(251, 274);
            this.MuokkaaHuonePainike.Name = "MuokkaaHuonePainike";
            this.MuokkaaHuonePainike.Size = new System.Drawing.Size(83, 29);
            this.MuokkaaHuonePainike.TabIndex = 13;
            this.MuokkaaHuonePainike.Text = "Muokkaa";
            this.MuokkaaHuonePainike.UseVisualStyleBackColor = false;
            this.MuokkaaHuonePainike.Click += new System.EventHandler(this.MuokkaaHuonePainike_Click);
            // 
            // UusiHuonePainike
            // 
            this.UusiHuonePainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UusiHuonePainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiHuonePainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.UusiHuonePainike.Location = new System.Drawing.Point(92, 274);
            this.UusiHuonePainike.Name = "UusiHuonePainike";
            this.UusiHuonePainike.Size = new System.Drawing.Size(153, 29);
            this.UusiHuonePainike.TabIndex = 12;
            this.UusiHuonePainike.Text = "Lisää uusi huone";
            this.UusiHuonePainike.UseVisualStyleBackColor = false;
            this.UusiHuonePainike.Click += new System.EventHandler(this.UusiHuonePainike_Click);
            // 
            // HuoneetDG
            // 
            this.HuoneetDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HuoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HuoneetDG.DefaultCellStyle = dataGridViewCellStyle1;
            this.HuoneetDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.HuoneetDG.Location = new System.Drawing.Point(422, 116);
            this.HuoneetDG.Name = "HuoneetDG";
            this.HuoneetDG.Size = new System.Drawing.Size(530, 222);
            this.HuoneetDG.TabIndex = 11;
            this.HuoneetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HuoneetDG_CellClick);
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostinumeroLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(196)))), ((int)(((byte)(104)))));
            this.PostinumeroLB.Location = new System.Drawing.Point(112, 231);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostinumeroLB.Size = new System.Drawing.Size(84, 27);
            this.PostinumeroLB.TabIndex = 7;
            this.PostinumeroLB.Text = "Vapaa:";
            // 
            // PuhelinTB
            // 
            this.PuhelinTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            this.PuhelinTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuhelinTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.PuhelinTB.Location = new System.Drawing.Point(213, 186);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(190, 29);
            this.PuhelinTB.TabIndex = 6;
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsoiteLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(196)))), ((int)(((byte)(104)))));
            this.OsoiteLB.Location = new System.Drawing.Point(100, 186);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OsoiteLB.Size = new System.Drawing.Size(96, 27);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "Puhelin:";
            // 
            // HuoneTyyppiLB
            // 
            this.HuoneTyyppiLB.AutoSize = true;
            this.HuoneTyyppiLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneTyyppiLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(196)))), ((int)(((byte)(104)))));
            this.HuoneTyyppiLB.Location = new System.Drawing.Point(40, 153);
            this.HuoneTyyppiLB.Name = "HuoneTyyppiLB";
            this.HuoneTyyppiLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HuoneTyyppiLB.Size = new System.Drawing.Size(156, 27);
            this.HuoneTyyppiLB.TabIndex = 3;
            this.HuoneTyyppiLB.Text = "Huonetyyppi: ";
            // 
            // HuoneenNroTB
            // 
            this.HuoneenNroTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            this.HuoneenNroTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneenNroTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.HuoneenNroTB.Location = new System.Drawing.Point(213, 116);
            this.HuoneenNroTB.Name = "HuoneenNroTB";
            this.HuoneenNroTB.Size = new System.Drawing.Size(190, 29);
            this.HuoneenNroTB.TabIndex = 2;
            // 
            // EtunimiLB
            // 
            this.EtunimiLB.AutoSize = true;
            this.EtunimiLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtunimiLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(196)))), ((int)(((byte)(104)))));
            this.EtunimiLB.Location = new System.Drawing.Point(44, 116);
            this.EtunimiLB.Name = "EtunimiLB";
            this.EtunimiLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EtunimiLB.Size = new System.Drawing.Size(152, 27);
            this.EtunimiLB.TabIndex = 1;
            this.EtunimiLB.Text = "Huoneen nro:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 81);
            this.panel2.TabIndex = 0;
            // 
            // HuonePaneeli
            // 
            this.HuonePaneeli.BackColor = System.Drawing.Color.ForestGreen;
            this.HuonePaneeli.Controls.Add(this.panel1);
            this.HuonePaneeli.Controls.Add(this.HuonetyyppiCB);
            this.HuonePaneeli.Controls.Add(this.TyhjennaHuonePainike);
            this.HuonePaneeli.Controls.Add(this.PoistaHuonePainike);
            this.HuonePaneeli.Controls.Add(this.MuokkaaHuonePainike);
            this.HuonePaneeli.Controls.Add(this.UusiHuonePainike);
            this.HuonePaneeli.Controls.Add(this.HuoneetDG);
            this.HuonePaneeli.Controls.Add(this.PostinumeroLB);
            this.HuonePaneeli.Controls.Add(this.PuhelinTB);
            this.HuonePaneeli.Controls.Add(this.OsoiteLB);
            this.HuonePaneeli.Controls.Add(this.HuoneTyyppiLB);
            this.HuonePaneeli.Controls.Add(this.HuoneenNroTB);
            this.HuonePaneeli.Controls.Add(this.EtunimiLB);
            this.HuonePaneeli.Controls.Add(this.panel2);
            this.HuonePaneeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HuonePaneeli.Location = new System.Drawing.Point(0, 0);
            this.HuonePaneeli.Name = "HuonePaneeli";
            this.HuonePaneeli.Size = new System.Drawing.Size(973, 372);
            this.HuonePaneeli.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.EiRB);
            this.panel1.Controls.Add(this.KyllaRB);
            this.panel1.Location = new System.Drawing.Point(213, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 46);
            this.panel1.TabIndex = 21;
            // 
            // EiRB
            // 
            this.EiRB.AutoSize = true;
            this.EiRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EiRB.ForeColor = System.Drawing.Color.Red;
            this.EiRB.Location = new System.Drawing.Point(126, 9);
            this.EiRB.Name = "EiRB";
            this.EiRB.Size = new System.Drawing.Size(47, 28);
            this.EiRB.TabIndex = 1;
            this.EiRB.TabStop = true;
            this.EiRB.Text = "EI";
            this.EiRB.UseVisualStyleBackColor = true;
            // 
            // KyllaRB
            // 
            this.KyllaRB.AutoSize = true;
            this.KyllaRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KyllaRB.ForeColor = System.Drawing.Color.Green;
            this.KyllaRB.Location = new System.Drawing.Point(16, 9);
            this.KyllaRB.Name = "KyllaRB";
            this.KyllaRB.Size = new System.Drawing.Size(90, 28);
            this.KyllaRB.TabIndex = 0;
            this.KyllaRB.TabStop = true;
            this.KyllaRB.Text = "KYLLÄ";
            this.KyllaRB.UseVisualStyleBackColor = true;
            // 
            // HuonetyyppiCB
            // 
            this.HuonetyyppiCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            this.HuonetyyppiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuonetyyppiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuonetyyppiCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.HuonetyyppiCB.FormattingEnabled = true;
            this.HuonetyyppiCB.Location = new System.Drawing.Point(212, 150);
            this.HuonetyyppiCB.Name = "HuonetyyppiCB";
            this.HuonetyyppiCB.Size = new System.Drawing.Size(190, 32);
            this.HuonetyyppiCB.TabIndex = 20;
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(973, 372);
            this.Controls.Add(this.HuonePaneeli);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HuoneidenHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HuoneidenHallinta";
            this.Load += new System.EventHandler(this.HuoneidenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.HuonePaneeli.ResumeLayout(false);
            this.HuonePaneeli.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TyhjennaHuonePainike;
        private System.Windows.Forms.Button PoistaHuonePainike;
        private System.Windows.Forms.Button MuokkaaHuonePainike;
        private System.Windows.Forms.Button UusiHuonePainike;
        private System.Windows.Forms.DataGridView HuoneetDG;
        private System.Windows.Forms.Label PostinumeroLB;
        private System.Windows.Forms.TextBox PuhelinTB;
        private System.Windows.Forms.Label OsoiteLB;
        private System.Windows.Forms.Label HuoneTyyppiLB;
        private System.Windows.Forms.TextBox HuoneenNroTB;
        private System.Windows.Forms.Label EtunimiLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel HuonePaneeli;
        private System.Windows.Forms.ComboBox HuonetyyppiCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton EiRB;
        private System.Windows.Forms.RadioButton KyllaRB;
    }
}