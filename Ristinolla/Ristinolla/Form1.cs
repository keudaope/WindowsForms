using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristinolla
{
    public partial class Ristinolla : Form
    {
        bool vuoro = true; //true = X:n vuoro, false = Y:n vuoro
        int vuorolaskuri = 0;
        public Ristinolla()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright Jyri Lindroos", "Ristinolla");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void napin_painallus(object sender, EventArgs e)
        {
            Button nappi = (Button)sender;
            if(vuoro)
            {
                nappi.Text = "X";
            }
            else
            {
                nappi.Text = "O";
            }
            vuoro = !vuoro;
            vuorolaskuri++;
            nappi.Enabled = false;
            tarkistaVoittaja();
        }

        private void tarkistaVoittaja()
        {
            bool voitto = false;
            // tarkistetaan, onko millään rivillä voittaaa
            if((R1S1.Text == R1S2.Text)&&(R1S1.Text == R1S3.Text)&&(!R1S1.Enabled))
            {
                voitto = true;
            }
            else if ((R2S1.Text == R2S2.Text) && (R2S1.Text == R2S3.Text) && (!R2S1.Enabled))
            {
                voitto = true;
            }
            else if ((R3S1.Text == R3S2.Text) && (R3S1.Text == R3S3.Text) && (!R3S1.Enabled))
            {
                voitto = true;
            }
            // tarkistetaan, onko missään sarakkeessa voittajaa
            else if ((R1S1.Text == R2S1.Text) && (R1S1.Text == R3S1.Text) && (!R1S1.Enabled))
            {
                voitto = true;
            }
            else if ((R1S2.Text == R2S2.Text) && (R1S2.Text == R3S2.Text) && (!R1S2.Enabled))
            {
                voitto = true;
            }
            else if ((R1S3.Text == R2S3.Text) && (R1S3.Text == R3S3.Text) && (!R1S3.Enabled))
            {
                voitto = true;
            }
            // Tarkistetaan, onko voittoja vinoittain
            else if ((R1S1.Text == R2S2.Text) &&(R1S1.Text == R3S3.Text) && (!R1S1.Enabled))
            {
                voitto = true;
            }
            else if ((R1S3.Text == R2S2.Text) &&(R1S3.Text == R3S1.Text) &&(!R1S3.Enabled))
            {
                voitto = true;
            }

            if (voitto)
            {
                lukitseNappulat();
                String voittaja = "";
                if (vuoro)
                {
                    voittaja = "O";
                }
                else
                {
                    voittaja = "X";
                }
                MessageBox.Show(voittaja + " on voittaja", "Jippii!");
            }
            else
            {
                if (vuorolaskuri == 9)
                {
                    MessageBox.Show("Tasapeli", "Harmi!");
                }

            }
            
        }

        private void lukitseNappulat()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button nappi = (Button)c;
                    nappi.Enabled = false;
                }
            }
            catch { }
            
            
        }

        private void newGameeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vuoro = true;
            vuorolaskuri = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button nappi = (Button)c;
                    nappi.Enabled = true;
                    nappi.Text = "";
                }
            }
            catch { }
        }
    }
}
