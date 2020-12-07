using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Hotellivarausja
{
    class VARAUS
    {
        Yhdista yhteys = new Yhdista();

        // Haetaan kaikki varaukset
        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huonekategoria", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
        
        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM varaukset", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        // Luodaan funktio asiakkaan tietojen muokkaamiseksi
        public bool lisaaVaraus(int hnro, int anro, DateTime sisaan, DateTime ulos)
        {
            
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `varaukset`" + 
               "(HuoneenNro, AsiakasId, Sisaan, Ulos) " +
               "VALUES (@hno, @aid, @sis, @ulo); ";
            
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();

            //@hno,@aid, @sis, @ulo
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = anro;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
            yhteys.avaaYhteys();
            try
            {
                if (komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }

        }
        public bool muokkaaVarausta(int hnro, int asid, DateTime sisaan, DateTime ulos, int vara)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `varaukset` SET `HuoneenNro`= @hno," +
                "`AsiakasId`= @aid,`Sisaan`= @sis,`Ulos`= @ulo" +
                " WHERE VarausId = @vid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            //@hno,@aid, @sis, @ulo, @vid
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = asid;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
            komento.Parameters.Add("@vid", MySqlDbType.Int32).Value = vara;

            //komento.Parameters.Add("@vid", MySqlDbType.VarChar).Value = varausId;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        // Luodaan funktio asiakkaan tietojen poistamiseen
        // tähän tarvitaan vain käyttäjätunnus
        public bool poistaVaraus(String varausnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM varaukset WHERE VarausId = @vno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu
            komento.Parameters.Add("@vno", MySqlDbType.VarChar).Value = varausnro;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
