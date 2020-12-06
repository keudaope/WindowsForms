using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Eramake;

namespace Hotellivarausja
{
    /*
     * Luodaan asiakasluokka seuraaville:
     * - Uuden asiakkaan lisäämiseen
     * - Olemassa olevan asiakkaan muokkaamiseen
     * - Olemassa olevan asiakkaan poistamiseen
     * - Kaikkien asiakkaiden hakuun
     */
    class ASIAKAS
    {
        Yhdista yhteys = new Yhdista();
        // Luodaan funktio, jonka avulla lisätään uusi asiakas

        public DataTable asiakaslista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT AsiakasId, Concat(Etunimi, ' ',Sukunimi) AS Kokonimi FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            // Lisätään Kokonimi-kenttä vastaukseen
           
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String pnro, String ppaikka, String kayttaja, String ssana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO asiakkaat " +
                "(kayttajanimi, Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, Salasana) " +
                "VALUES (@ktu, @enm, @snm, @oso, @pno, @ptp, @ssa); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu,@enm, @snm, @oso, @pno, @ptp, @ssa
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            if (kayttaja !="")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja.ToLower();
            }
            else
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            }
            if(ssana !="")
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = eCryptography.Encrypt(ssana);
            }
            else
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = eCryptography.Encrypt(luoSalasana());
                MessageBox.Show(luoSalasana());
            }
            
            
            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
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

        //Luodaan salasana
        public String luoSalasana()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#€?0123456789".ToCharArray();
            Random satunnaisluku = new Random();
            String salasana = "";
            for(int i = 0; i < 12; i++)
            {
                int indeksi = satunnaisluku.Next(alpha.Length);
                salasana += alpha[indeksi];
            }
            return salasana;
        }
        

        // Luodaan funktio kaikkien asiakastietojan hakemiseksi
        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, kayttajanimi FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        // Luodaan funktio asiakkaan tietojen muokkaamiseksi
        public bool muokkaaAsiakasta(String enimi, String snimi, String osoite, String pnro, String ppaikka, String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `asiakkaat` SET `Etunimi`= @enm," +
                "`Sukunimi`= @snm,`Lahiosoite`= @oso,`Postinumero`= @pno,`Postitoimipaikka`= @ptp" +
                " WHERE kayttajanimi = @ktu";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu,@enm, @snm, @oso, @pno, @ptp, @ssa
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;



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
        public bool poistaAsiakas(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM asiakkaat WHERE kayttajanimi = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

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
