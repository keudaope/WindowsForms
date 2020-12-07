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
    public partial class VaraustenHallinta : Form
    {
        HUONE huone = new HUONE();
        ASIAKAS asiakas = new ASIAKAS();
        VARAUS varaus = new VARAUS();
        public VaraustenHallinta()
        {
            InitializeComponent();
        }

        private void UusiVarausPainike_Click(object sender, EventArgs e)
        {
            int asiakas = Convert.ToInt32(AsiakasCB.SelectedValue.ToString());
            int huone = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(SisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(UlosDTP.Value);
            //MessageBox.Show(asiakas.ToString() + " " + huone.ToString() + " " + sisaankirjautuminen.ToString() + " " + uloskirjautuminen.ToString());
            if (varaus.lisaaVaraus(huone, asiakas, sisaankirjautuminen, uloskirjautuminen))
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void VaraustenHallinta_Load(object sender, EventArgs e)
        {
            // Haetaan listaus funktiosta huonetyyppilista
            // Näytetään huonetyypin nimi (DisplayMember),
            // Mutta lähetetään eteenpäin KategoriaId (ValueMember)
            HuonetyyppiCB.DataSource = huone.huonetyyppilista();
            HuonetyyppiCB.DisplayMember = "Huonetyyppi";
            HuonetyyppiCB.ValueMember = "KategoriaId";

            // Haetaan listaus funktiosta asiakaslista
            // Näytetään Asiakkaan nimi (DisplayMember),
            // Mutta lähetetään eteenpäin KategoriaId (ValueMember)

            AsiakasCB.DataSource = asiakas.asiakaslista();
            AsiakasCB.DisplayMember = "Kokonimi";
            AsiakasCB.ValueMember = "AsiakasId";
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void HuonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Koska alin huonetyyppi = 1 ja index alkaa 0:sta, täytyy kasvattaa yhdellä
            int huonetype = HuonetyyppiCB.SelectedIndex + 1;

            // Haetaan Huonenumerot huonetyypin perusteella
            HuoneNroCB.DataSource = huone.tyypillisetHuoneet(huonetype);
            HuoneNroCB.DisplayMember = "HuoneenNro";
            HuoneNroCB.ValueMember = "HuoneenNro";
        }

        private void MuokkaaVaraustaPainike_Click(object sender, EventArgs e)
        {
            int huone = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            int asiakas = Convert.ToInt32(AsiakasCB.SelectedValue.ToString());
            DateTime sisaan = Convert.ToDateTime(SisaanDTP.Value);
            DateTime ulos = Convert.ToDateTime(UlosDTP.Value);
            try
            {
                int vara = Convert.ToInt32(VarausNroTB.Text);

                if (varaus.muokkaaVarausta(huone, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void VarauksetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VarauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(VarauksetDG.CurrentRow.Cells[0].Value.ToString(), "Eka Arvo");
            VarausNroTB.Text = VarauksetDG.CurrentRow.Cells[0].Value.ToString();
            AsiakasCB.SelectedValue = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            HuoneNroCB.SelectedValue = VarauksetDG.CurrentRow.Cells[1].Value.ToString();
            SisaanDTP.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[3].Value);
            UlosDTP.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[4].Value);
        }

        private void PoistaVarausPainike_Click(object sender, EventArgs e)
        {
            try
            {
                String varausnro = VarausNroTB.Text;
                if (varaus.poistaVaraus(varausnro))
                {
                    VarauksetDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varaus ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TyhjennaVarausPainike.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
    }
}
