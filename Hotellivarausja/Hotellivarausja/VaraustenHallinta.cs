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

        }

        private void HuonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Koska alin huonetyyppi = 1 ja index alkaa 0:sta, täytyy kasvattaa yhdellä
            int huonetype = HuonetyyppiCB.SelectedIndex+1;

            // Haetaan Huonenumerot huonetyypin perusteella
            HuoneNroCB.DataSource = huone.tyypillisetHuoneet(huonetype);
            HuoneNroCB.DisplayMember = "HuoneenNro";
            HuoneNroCB.ValueMember = "HuoneenNro";
        }
    }
}
