using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Program
    {
        static void Main(string[] args)
        {
            Evidence evidence = new Evidence("evidence pojistných událostí");
            char volba = '0';
            evidence.DefaultniKlienti();
            while (volba != '5')
            {
                evidence.VypisUvodniInformace();
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                
                switch (volba)
                {
                    case '1':
                        evidence.PridatNovehoPojisteneho();
                        break;
                    case '2':
                        evidence.VypisVsechnyPojistene();
                        break;
                    case '3':
                        evidence.NajdiPojisteneho();
                        break;
                    case '4':
                        evidence.vymazZEvidence();
                        break;
                    case '5':
                        Console.WriteLine("aplikace se rozlouci a ukonci");
                        break;
                }
            }
        }
    }
}
