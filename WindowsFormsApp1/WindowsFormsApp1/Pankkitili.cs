using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class Pankkitili
    {
        // Muuttujan yksityiseksi, ei käsiksi muualta kuin tästä luokasta
        private string omistaja;
        private string tilinumero;
        private double saldo;

        // Oletuskonstruktori
        public Pankkitili()
        {
            omistaja = "";
            tilinumero = "";
            saldo = 0;
        }

        
        public Pankkitili(string uomistaja, string utilinumero, double usaldo)
        {
            omistaja = uomistaja;
            tilinumero = utilinumero;
            saldo = usaldo;
        }

        // Ylirasitettu konstruktori, uusi tapa (jos vain yksi muutettava)
       /* public Pankkitili(string uomistaja) => Omistaja = uomistaja; */

        // getterit ja setterit, normaalitapa
       /* public string Omistaja
        {
            get
            {
                return omistaja;
            }
            set
            {
                omistaja = value;
            }
        }*/

        // getterit ja setterit, uusi, lyhyempi tapa
        public string Omistaja
        {
            get => omistaja;
            set => omistaja = value;
        }
        public string Tilinumero
        {
            get => tilinumero;
            set => tilinumero = value;
        }
        public double Saldo
        {
            get => saldo;
            set => saldo = value;
        }



    }

    
}
