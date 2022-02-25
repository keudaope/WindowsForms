using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace graafinen
{
    public partial class Sijoitukset : Form
    {
        public Sijoitukset()
        {
            InitializeComponent();
        }
        private void Sijoitukset_Load(object sender, EventArgs e)
        {
            int alku, loppu;
            alku = haePienin(1)-25;
            loppu = haeSuurin(1)+25;
            PiirraTaulukko(tulostaulu, alku, loppu, 1);
            alku = haePienin(2)-25;
            loppu = haeSuurin(2)+25;
            PiirraTaulukko(TulostauluNordicMCB, alku, loppu, 2);
            alku = haePienin(3) - 25;
            loppu = haeSuurin(3) + 25;
            PiirraTaulukko(TulostauluNordicSCB, alku, loppu, 3);
            alku = haePienin(6) - 25;
            loppu = haeSuurin(6) + 25;
            PiirraTaulukko(TulostauluRoburRA, alku, loppu, 6);
            alku = haePienin(7) - 25;
            loppu = haeSuurin(7) + 25;
            PiirraTaulukko(TulostauluRoburTA, alku, loppu, 7);
            alku = haePienin(8) - 25;
            loppu = haeSuurin(8) + 25;
            PiirraTaulukko(LiteCoinChart, alku, loppu, 8);
            alku = haePienin(9) - 25;
            loppu = haeSuurin(9) + 25;
            PiirraTaulukko(EthereumChart, alku, loppu, 9);
            alku = haePienin(10) - 25;
            loppu = haeSuurin(10) + 25;
            PiirraTaulukko(RippleChart, alku, loppu, 10);
            alku = haePienin(11) - 25;
            loppu = haeSuurin(11) + 25;
            PiirraTaulukko(StellarLumensChart, alku, loppu, 11);
        }
        public void PiirraTaulukko(Chart taulu, int min, int max, int rahasto)
        {
            MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=sijoitukset");
            MySqlCommand komento = new MySqlCommand("SELECT Paiva, Rahasto, MarkkinaArvo FROM aktia, tilanne WHERE aktia.RahastoId = tilanne.RahastoId AND aktia.RahastoId = @rah", yhteys);
            komento.Parameters.Add("@rah", MySqlDbType.VarChar).Value = rahasto;
            MySqlDataReader lukija;
            taulu.ChartAreas[0].AxisY.Minimum = min;
            taulu.ChartAreas[0].AxisY.Maximum = max;
            try
            {
                yhteys.Open();
                lukija = komento.ExecuteReader();
                while (lukija.Read())
                {
                    taulu.Series["MarkkinaArvo"].Points.AddXY(lukija.GetString("Paiva"), lukija.GetDouble("MarkkinaArvo"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe " + ex);
            }
            yhteys.Close();
        }
        public int haePienin(int rahasto)
        {
            int pienin=0;
            MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=sijoitukset");
            MySqlCommand komento = new MySqlCommand("SELECT Min(MarkkinaArvo) AS Minimi FROM `tilanne` WHERE RahastoId = @rah", yhteys);
            komento.Parameters.Add("@rah", MySqlDbType.VarChar).Value = rahasto;
            MySqlDataReader lukija;
            try
            {
                yhteys.Open();
                lukija = komento.ExecuteReader();
                while (lukija.Read())
                {
                    pienin = Convert.ToInt32(lukija.GetDouble(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe " + ex);
            }
            yhteys.Close();
            return pienin;
        }
        public int haeSuurin(int rahasto)
        {
            int suurin = 0;
            MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=sijoitukset");
            MySqlCommand komento = new MySqlCommand("SELECT Max(MarkkinaArvo) AS Maksimi FROM `tilanne` WHERE RahastoId = @rah", yhteys);
            komento.Parameters.Add("@rah", MySqlDbType.VarChar).Value = rahasto;
            MySqlDataReader lukija;
            try
            {
                yhteys.Open();
                lukija = komento.ExecuteReader();
                while (lukija.Read())
                {
                    suurin = Convert.ToInt32(lukija.GetDouble(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe " + ex);
            }
            yhteys.Close();
            return suurin;
        }

        private void syötäArvojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 syotto = new Form2();
            syotto.ShowDialog();

        }

        private void näytäRahastotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sijoitukset nayta = new Sijoitukset();
            nayta.ShowDialog();
        }
    }
}
