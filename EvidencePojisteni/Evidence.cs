using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Evidence
    {
        List<Klient> databazeKlientu = new List<Klient>();


        public string nazevEvidence;
        public DateTime dnesJe;


        //konstruktor evidence
        public Evidence(string nazev)
        {
            nazevEvidence = nazev;
        }
        //TO STRING evidence
        public override string ToString()
        {
            return "nacházíte se v programu " + nazevEvidence;
        }
        //přidej klienta do evidence
        public void PridatNovehoPojisteneho()
        {
            Console.WriteLine("zadej jméno: ");
            string vstupJmeno = Console.ReadLine();
            Console.WriteLine("zadej příjmení: ");
            string vstupPrijmeni = Console.ReadLine();
            Console.WriteLine("zadej věk klienta: ");
            int vstupVek = int.Parse(Console.ReadLine());
            Console.WriteLine("zadej telefonní číslo klienta: ");
            string vstupTelCislo = (Console.ReadLine());

            databazeKlientu.Add(new Klient(vstupJmeno, vstupPrijmeni, vstupVek, vstupTelCislo));
        }
        //vypis vsechny klienty v databázy
        public void VypisVsechnyPojistene()
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("V evidenci pojištěných se nachazi: \n");
            foreach (Klient osoba in databazeKlientu)
            {
                Console.WriteLine(osoba + "\n");
            }
        }
        //vyhleda konkretniho klienta
        public void NajdiPojisteneho()
        {
            Console.WriteLine(  "zadejte jméno klienta, kterého chcete vyhledat: ");
            string jmenoVstup = Console.ReadLine();
            Console.WriteLine(  "zadejte příjmení klienta, kterého chcete vyhledat: ");
            string prijmeniVstup = Console.ReadLine();

            List<Klient> nalezene = new List<Klient>();

            foreach (Klient clovek in databazeKlientu)
            {
                if ((clovek.Jmeno == jmenoVstup) && (clovek.Prijmeni == prijmeniVstup))
                {
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("nalezeno:");
                    Console.WriteLine(clovek);
                    nalezene.Add(clovek);
                }
            }
        }
        //vymaže klienta z evidence
        public void vymazZEvidence()
        {
            Console.WriteLine(  "zadejte jméno klienta, ktereho chcete vymazat z evidence: ");
            string jmenoVymazat = Console.ReadLine();
            Console.WriteLine(  "zadejte příjmení klienta, kterého chcete vymazat z evidence");
            string prijmeniVymazat = Console.ReadLine();

            int indexKlientaKeSmazani = 0;
            foreach (Klient keSmazani in databazeKlientu)
            {
                if ((keSmazani.Jmeno == jmenoVymazat)&& (keSmazani.Prijmeni == prijmeniVymazat))
                {
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("z evidence bude vymazán klient:");
                    Console.WriteLine(keSmazani);
                    indexKlientaKeSmazani = databazeKlientu.IndexOf(keSmazani);
                }
            }
            databazeKlientu.RemoveAt(indexKlientaKeSmazani);
        }
        //úvod o aplikaci
        public void VypisUvodniInformace()
        {
            Console.WriteLine("Vítejte v aplikaci pro evidenci pojistných událostí");
            Console.WriteLine("Dnes je: " + DateTime.Now);
            Console.WriteLine("Počet momentálně evidovaných klientů: " + databazeKlientu.Count);
            Console.WriteLine("_______________________________________");
            Console.WriteLine();
            Console.WriteLine("vyberte si akci: ");
            Console.WriteLine("1 - přidat nového pojištěného");
            Console.WriteLine("2 - vypsat všechny pojištěné");
            Console.WriteLine("3 - vyhledat pojištěného");
            Console.WriteLine("4 - vyřadí pojištěného z evidence");
            Console.WriteLine("5 - konec");
            Console.WriteLine("_______________________________________");

        }
        //defaultni klienti uložení v aplikaci
        public void DefaultniKlienti()
        {
            databazeKlientu.Add(new Klient("Alois", "Bednář", 58, 777878905));
            databazeKlientu.Add(new Klient("Barbora", "Matoušková", 29, 605605604));
        }

    }
}
