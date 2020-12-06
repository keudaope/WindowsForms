using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellivarausja
{
    /*
     * Tämän luokan avulla hallitsemme huoneita
     * Tee kuitenkin huonekategoriaa varten oma taulukkonsa
     * phpMyAdminin avulla, jossa on seuraavat kentät
     * - KategoriaID (Primary key)
     * - Huone tyyppi (Yhden hengen, Kahden hengen, Perhehuone, Sviitti)
     * - Hinta (120, 90, 150, 300)
     * 
     *      CREATE TABLE `hotelli`.`huonekategoria` 
     *      ( `kategoriaId` INT NOT NULL AUTO_INCREMENT , `Huonetyyppi` VARCHAR(15) NOT NULL , `Hinta` DECIMAL NOT NULL , PRIMARY KEY (`kategoriaId`))
     *      
     *      INSERT INTO huonekategoria (Huonetyyppi, Hinta) VALUES 
     *      ("Yhden hengen", 120.00), ("Kahden hengen", 90.00), ("Perhe", 150.00), ("Sviitti", 300.00)
     *      
     * Ja Huoneet-taulukko, jossa on seuraavat kentät
     * - Huoneen numero (kerroksittain)
     * - Huoneen tyyppi (valitaan huonekategoriasta)
     * 
     *      CREATE TABLE huoneet (
     *      Huoneen_numero INTEGER PRIMARY KEY,
     *      Huonetyyppi INTEGER,
     *      FOREIGN KEY(Huonetyyppi) REFERENCES huonekategoria(kategoriaId));
     */
    class HUONE
    {
        Yhdista yhteys = new Yhdista();
        // luodaan funktio huonetyyppien listaamiseksi
        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huonekategoria", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        // luodaan funktio uuden huoneen lisäämiseksi
        public bool lisaaHuone(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO huoneet " +
                "(HuoneenNro, Huonetyyppi, Puhelin, Vapaa) " +
                "VALUES (@hno, @hty, @puh, @vap); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            //@hno,@hty, @puh, @vap
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;
           
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
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }
            
        }

        // Luodaan funktio kaikkien huoneiden listaamiseksi
        public DataTable haeHuoneet()
        {

            MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        // luodaan funktio huoneen muokkaamiseksi
        public bool muokkaaHuonetta(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `huoneet` SET `Huonetyyppi`= @hty," +
                "`Puhelin`= @puh,`Vapaa`= @vap" +
                " WHERE HuoneenNro = @hno";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            //@hno,@hty, @puh, @vap
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

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

        // luodaan funktio huoneen poistamiseksi
        public bool poistaHuone(String hnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM huoneet WHERE HuoneenNro = @hno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            //@hno
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;

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
        // Tämän avulla haetaan huoneet Varauslomakkeelle sen mukaan, mitä huonetyypiksi on merkitty
        public DataTable tyypillisetHuoneet(int htype)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "SELECT * from huoneet WHERE Huonetyyppi = @hty";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            //@hty
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htype;
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
    }
}
