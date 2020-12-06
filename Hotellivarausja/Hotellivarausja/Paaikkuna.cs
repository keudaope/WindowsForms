using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellivarausja
{
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void Paaikkuna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            AsiakkaidenHallinta ahlomake = new AsiakkaidenHallinta();
            ahlomake.ShowDialog();

        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VaraustenHallinta vhlomake = new VaraustenHallinta();
            vhlomake.ShowDialog();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuoneidenHallinta hhlomake = new HuoneidenHallinta();
            hhlomake.ShowDialog();
        }

        
    }
}
