using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TalletusFormi : Form
    {
        private int laskuri = 0;
        public TalletusFormi()
        {
            InitializeComponent();
        }

        private void UusiTiliButton_Click(object sender, EventArgs e)
        {
            string om = OmistajaTextBox.Text;
            OmistajaTextBox.Text = "";
            string tn = TilinroTextBox.Text;
            TilinroTextBox.Text = "";
            double sd = double.Parse(SaldoTextBox.Text);
            SaldoTextBox.Text = "";
            Console.WriteLine("Omistaja {0}, tilinro {1} ha saldo {2}", om, tn, sd);
            

        }
    }
}
