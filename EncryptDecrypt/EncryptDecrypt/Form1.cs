using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eramake;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void EncPainike_Click(object sender, EventArgs e)
        {
            EncTB.Text = eCryptography.Encrypt(SalasanaTB.Text);
        }

        private void DecPainike_Click(object sender, EventArgs e)
        {
            DecTB.Text = eCryptography.Decrypt(EncTB.Text);
        }
    }
}
