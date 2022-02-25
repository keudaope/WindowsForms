using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graafinen
{
    public partial class Form2 : Form
    {
        Yhteys yhteys = new Yhteys();
        public Form2()
        {
            InitializeComponent();
            RahastoCB.DataSource = haeSijoitukset();
            RahastoCB.DisplayMember = "Rahasto";
            RahastoCB.ValueMember = "RahastoId";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Haetaan listaus funktiosta huonetyyppilista
            // Näytetään huonetyypin nimi (DisplayMember),
            // Mutta lähetetään eteenpäin KategoriaId (ValueMember)
            _ = MessageBox.Show("Tähän päästiin!");
            RahastoCB.DataSource = haeSijoitukset();
            RahastoCB.DisplayMember = "Rahasto";
            RahastoCB.ValueMember = "RahastoId";

           // HuoneetDG.DataSource = huone.haeHuoneet();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public DataTable haeSijoitukset()
        {

            MySqlCommand komento = new MySqlCommand("SELECT * FROM aktia", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }
        public void tallennaTietokantaan(string paivays, int rahasto, float arvo)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `tilanne`(`Paiva`, `MarkkinaArvo`, `RahastoId`) VALUES(@pvm, @arv, @rah);";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            //@hno,@hty, @puh, @vap
            komento.Parameters.Add("@pvm", MySqlDbType.VarChar).Value = paivays;
            komento.Parameters.Add("@rah", MySqlDbType.Int32).Value = rahasto;
            komento.Parameters.Add("@arv", MySqlDbType.Float).Value = arvo;
            yhteys.avaaYhteys();
            try
            {
                if (komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    //return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                   //return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                //return true;
            }
        }

        private void TallennaBt_Click(object sender, EventArgs e)
        {
            DateTime paiva = PaivaysDP.Value;
            string paivat = paiva.ToString("yyyy-M-dd");
            int rahasto = (int)RahastoCB.SelectedValue;
            float summa = float.Parse(KurssiTB.Text);
            tallennaTietokantaan(paivat, rahasto, summa);
            RahastoCB.SelectedValue = -1;
            KurssiTB.Text = "";
        }
    }
}
