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
    public partial class HuoneidenHallinta : Form
    {
        public HuoneidenHallinta()
        {
            InitializeComponent();
        }

        HUONE huone = new HUONE();

        private void HuoneidenHallinta_Load(object sender, EventArgs e)
        {
            // Haetaan listaus funktiosta huonetyyppilista
            // Näytetään huonetyypin nimi (DisplayMember),
            // Mutta lähetetään eteenpäin KategoriaId (ValueMember)
            HuonetyyppiCB.DataSource = huone.huonetyyppilista();
            HuonetyyppiCB.DisplayMember = "Huonetyyppi";
            HuonetyyppiCB.ValueMember = "KategoriaId";

            HuoneetDG.DataSource = huone.haeHuoneet();
        }

        private void UusiHuonePainike_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HuoneenNroTB.Text);
            int tyyppi = Convert.ToInt32(HuonetyyppiCB.SelectedValue.ToString());
            String puhelin = PuhelinTB.Text;
            if(huone.lisaaHuone(numero, tyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneetDG.DataSource = huone.haeHuoneet();
        }

        private void TyhjennaHuonePainike_Click(object sender, EventArgs e)
        {
            HuoneenNroTB.Text = "";
            HuonetyyppiCB.SelectedIndex = 0;
            PuhelinTB.Text = "";
        }

        private void HuoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneenNroTB.Text = HuoneetDG.CurrentRow.Cells[0].Value.ToString();
            HuonetyyppiCB.SelectedValue = HuoneetDG.CurrentRow.Cells[1].Value.ToString();
            PuhelinTB.Text = HuoneetDG.CurrentRow.Cells[2].Value.ToString();
        }

        private void MuokkaaHuonePainike_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(HuonetyyppiCB.SelectedValue.ToString());
            String puhelin = PuhelinTB.Text;
            String vapaa = "";
            try
            {
                int numero = Convert.ToInt32(HuoneenNroTB.Text);
                if (KyllaRB.Checked)
                {
                    vapaa = "Kyllä";
                }
                else
                {
                    vapaa = "Ei";
                }
                if (huone.muokkaaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneetDG.DataSource = huone.haeHuoneet();
        }

        private void PoistaHuonePainike_Click(object sender, EventArgs e)
        {
            try
            {
                String huonenro = HuoneenNroTB.Text;
                if (huone.poistaHuone(huonenro))
                {
                    HuoneetDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TyhjennaHuonePainike.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
            
        }

        private void HuoneenNroTB_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
