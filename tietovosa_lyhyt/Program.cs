using System.Globalization;

namespace Homework
{
    internal class Program
    {

        //Funktion julistuminen
        // paluuarvon tyyppi / funktion nimi
        static int TeeKysymys(String kysymys, string oikeaVastaus) //funktion otsikko, tunniste
        {
            Console.WriteLine(kysymys);
            string vastaus = Console.ReadLine();
            if (vastaus.ToLower() == oikeaVastaus)
            {
                return 1; //palauta luku 1. Funktio loppuu
            }
            else
            {
                return 0; //Väärin, ei pistetä
            }
        }
        static int TeeKysymys(string kysymys, int oikeaVastaus)
        {
            // Sama kuin TeeKysymys (string, string)
            // mutta lisäksi TryParse()
            Console.WriteLine(kysymys);
            string vastaus = Console.ReadLine();

            if (int.TryParse(vastaus, out int numeroVastaus))
            {
                if (numeroVastaus == oikeaVastaus)
                {
                    return 1; // Oikea vastaus
                }
            }

            return 0; // Väärä vastaus
        }
        public static void Main(string[] args)
        {
            // Luo muuttuja pisteitä varten
            int pisteet = 0;
            // Luo muuttuja joka muistaa onko vastaus oikeaa tyyppiä

            pisteet += TeeKysymys("Mikä on Ruotsin pääkaupunki?", "tukholma");
            pisteet += TeeKysymys("Mistä saa rahaa?", "en tiedä");
            pisteet += TeeKysymys("Mitä on 2+2?", "4");
            pisteet += TeeKysymys("Mikä on Suomen pääkaupunki?", "helsinki");
            pisteet += TeeKysymys("Mikä on Suomen pisin joki?", "kemijoki");
            pisteet += TeeKysymys("Mikä on Suomen suurin järvi?", "saimaa");
            pisteet += TeeKysymys("Mikä on Suomen korkein vuori?", "halti");
            pisteet += TeeKysymys("Mikä on pii kahdella desimaalilla?", "3.14");
            pisteet += TeeKysymys("Mikä on elämän tarkoitus?", "onni");

            Console.WriteLine("Pisteiden määrä on " + pisteet);

        }
    }
}