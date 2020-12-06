using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Eramake;

namespace Hotellivarausja
{
    public partial class Kirjautumisikkuna : Form
    {
        public Kirjautumisikkuna()
        {
            InitializeComponent();
        }

        private void Kirjautumisikkuna_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KirjauduPainike_Click(object sender, EventArgs e)
        {
            // HUOM! Käytetään itse luotua luokkaa Yhdista
            Yhdista tietokantaan = new Yhdista();
            // Luodaan muuttujia yhdistämistä varten
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();
            // Tehdään kysely
            String kysely = "SELECT kayttajanimi, salasana FROM asiakkaat WHERE kayttajanimi = @kn AND Salasana = @ss";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.otaYhteys();

            // Lisätään lomakkeelta muuttujiin @kn ja @ss tiedot
            komento.Parameters.Add("@kn", MySqlDbType.VarChar).Value = KayttajaTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = eCryptography.Encrypt(SalasanaTB.Text);

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            // Tarkistetaan, onko salasanaa ja käyttäjänimeä
            if(taulu.Rows.Count > 0)
            {
                // Piilotetaan tämä lomake ja avataan Pääikkkuna
                this.Hide();
                Paaikkuna plomake = new Paaikkuna();
                plomake.Show();

                //MessageBox.Show("Tietoja löytyy");
            }
            else
            {
                if(KayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjänimesi kirjautuaksesi", "Käyttäjänimi on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (SalasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana kirjautuaksesi", "Salasana on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
