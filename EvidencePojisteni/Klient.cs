using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Klient
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public string TelCislo { get; private set; }

        //konstruktor klienta
        public Klient(string jmeno, string prijmeni, int vek, string telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelCislo = telCislo;
        }
        //TO STRING
        public override string ToString()
        {
            return "JMÉNO: " + Jmeno + "\n" + "PŘÍJMENÍ: " + Prijmeni + "\n" + "VĚK: " + Vek + " let \n" + "telefonní číslo: " + TelCislo;
        }

    }
}
