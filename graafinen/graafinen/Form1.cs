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
            PiirraTaulukko(tulostaulu, 950, 1250, 1);
            PiirraTaulukko(TulostauluNordicMCB, 5900, 6200, 2);
            PiirraTaulukko(TulostauluNordicSCB, 2175, 2475, 3);
            PiirraTaulukko(TulostauluRoburAA, 1250, 1550, 4);
            PiirraTaulukko(TulostauluRoburJA, 4400, 4700, 5);
            PiirraTaulukko(TulostauluRoburRA, 4900, 5200, 6);
            PiirraTaulukko(TulostauluRoburTA, 5520, 5820, 7);
            PiirraTaulukko(TulostauluAlibaba, 1650, 1950, 8);
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
    }
}
