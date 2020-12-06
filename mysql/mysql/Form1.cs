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

namespace mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajaKysely();
        }

        private void ajaKysely()
        {
            string kysely = textBox1.Text;

            if(kysely == "")
            {
                MessageBox.Show("Ole hyvä ja syötä kysely");
                return;
            }

            string yhteys = "datasource=127.0.0.1; port=3306;username=root;password=;database=osoite";
            MySqlConnection tietokantayhteys = new MySqlConnection(yhteys);
            MySqlCommand komento = new MySqlCommand(kysely, tietokantayhteys);
            komento.CommandTimeout = 60;

            try
            {
                tietokantayhteys.Open();
                MySqlDataReader lukija = komento.ExecuteReader();

                if (lukija.HasRows)
                {
                    while(lukija.Read())
                    {
                        Console.WriteLine(lukija.GetString(0) + " " + lukija.GetString(1) + " " + lukija.GetString(2) + " " + lukija.GetString(3) + " " + lukija.GetString(4) + " " + lukija.GetString(5));
                    }
                }
                else
                {
                    MessageBox.Show("kysely suoritettu");
                }

            }
            catch(Exception poikkeus)
            {
                MessageBox.Show("Kyselyvirhe: " + poikkeus.Message);
            }
        }
    }
}
