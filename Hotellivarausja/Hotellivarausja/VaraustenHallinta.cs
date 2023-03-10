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
            int huonenro = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(SisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(UlosDTP.Value);
            //MessageBox.Show(asiakas.ToString() + " " + huone.ToString() + " " + sisaankirjautuminen.ToString() + " " + uloskirjautuminen.ToString());
            
                if(sisaankirjautuminen <= DateTime.Now)
                {
                    MessageBox.Show("Sisäänkirjautumisen täytyy olla tämä päivä tai sen jälkeen", "Päivämäärän tarkastus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(uloskirjautuminen < sisaankirjautuminen)
                {
                    MessageBox.Show("Uloskirjautumisen täytyy olla sisäänkirjautumispäivä tai jälkeen", "Päivämäärän tarkastus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (varaus.lisaaVaraus(huonenro, asiakas, sisaankirjautuminen, uloskirjautuminen))
                    {
                        MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       /* if (huone.vaihdaHuoneenVapaus("Kyllä", huonenro))
                        {
                            MessageBox.Show("Huoneen varaustilanne vaihdettu onnistuneesti");
                        }
                        else
                        {
                            MessageBox.Show("Huoneen varaustilannetta ei pystytty vaihtamaan");
                        }*/
                    }
                    else
                    {
                        MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    VarauksetDG.DataSource = varaus.haeVaraukset();
                }    
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
            int huonenro = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            int asiakas = Convert.ToInt32(AsiakasCB.SelectedValue.ToString());
            DateTime sisaan = Convert.ToDateTime(SisaanDTP.Value);
            DateTime ulos = Convert.ToDateTime(UlosDTP.Value);
            try
            {
                int vara = Convert.ToInt32(VarausNroTB.Text);

                if (varaus.muokkaaVarausta(huonenro, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Varaus muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int hnro = Convert.ToInt32(VarauksetDG.CurrentRow.Cells[1].Value.ToString());
            int htyp = Convert.ToInt32(huone.haeHuoneenTyyppi(hnro));
            HuoneNroCB.SelectedValue = hnro;
          /* if (huone.vaihdaHuoneenVapaus("Ei", hnro))
            {
                MessageBox.Show("Huoneen varaustilanne vaihdettu onnistuneesti");
            }
            else
            {
                MessageBox.Show("Huoneen varaustilannetta ei pystytty vaihtamaan");
            }*/
            HuonetyyppiCB.SelectedValue = htyp;
            AsiakasCB.SelectedValue = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            SisaanDTP.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[3].Value);
            UlosDTP.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[4].Value);
        }

        private void PoistaVarausPainike_Click(object sender, EventArgs e)
        {
            try
            {
                String varausnro = VarausNroTB.Text;
                int huonenro = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
                
                if (varaus.poistaVaraus(varausnro))
                {
                    VarauksetDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   /* if (huone.vaihdaHuoneenVapaus("Ei", huonenro))
                    {
                        MessageBox.Show("Huoneen varaustilanne vaihdettu onnistuneesti");
                    }
                    else
                    {
                        MessageBox.Show("Huoneen varaustilannetta ei pystytty vaihtamaan");
                    }*/
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

        private void UlosDTP_ValueChanged(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(SisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(UlosDTP.Value);
                if (varaus.tarkistaPaiva(sisaankirjautuminen, uloskirjautuminen, huonenro))
                {
                   // MessageBox.Show("Päivät ovat vapaat", "Päivämäärän tarkastus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("tämä päivä on varattu tuossa huoneessa", "Päivämäärän tarkastus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TyhjennaVarausPainike.PerformClick();
                }
        }

        private void TyhjennaVarausPainike_Click(object sender, EventArgs e)
        {
            VarausNroTB.Text = "";
            AsiakasCB.SelectedIndex = -1;
            HuonetyyppiCB.SelectedIndex = 0;
            HuoneNroCB.SelectedIndex = 0;
            SisaanDTP.Value = DateTime.Now;
            UlosDTP.Value = DateTime.Now;

        }
    }
}
