/* Tehtävä:
Tee ohjelma, joka kysyy käyttäjältä erilaisia 
kysymyksiä, joihin on vain yksi oikea vastaus.
Jos käyttäjä vastaa oikein, annetaan 1 piste.
Jos käyttäjä vastaa väärin, ei saa pistettä.
Jos vastaus on väärin tyyppinen, esim. vastaa
numeroita kun pitäisi vastata teksiä, ohjelma näyttää
virheilmoituksen ja kysyy uudestaan.

Kun kaikki kysymykset on kysytty, ohjelma näyttää kuinka
monta pistettä pelaaja sai.
*/

// Luo muuttuja pisteitä varten
// Tervehti pelaaja
// Esitä kysymys 1
// Lue pelaajan vastaus
// Tarkista onko vastaus oikea tyyppiä
// Jos vastaus on väärää tyyppiä, esitä kysymys uudestaan
// Tarkista onko vastaus oikein  vain väärin
// Jos vastaus on oikein, lisää pisteisiin 1 ja mene suoraavaan kysymykseen
// Jos vastaus on väärin, mene seuraavaan kysymykseen
// Esitä kysymys 2 ja niin edeleeen...

// Mikä joki on suomen pisin? Kemijoki
// Mikä järvi on Suomen suurin? Saimaa
// Mikä vuori on Suomen korkein?  Halti (1 324 metriä)

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

namespace Homework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Luo muuttuja pisteitä varten
            int pisteet = 0;
            // Luo muuttuja joka muistaa onko vastaus oikeaa tyyppiä
            bool oikeaTyyppi = true;

            Console.Clear();
            // Tervehti pelaaja
            Console.WriteLine("Tervetuloa tietovisaan! Et voi voittaaa palkintoja");
            // Esitä kysymys 1
            Console.WriteLine("Mitä on 2+2?");
            // Lue pelaajan vastaus
            do
            {
                String vastaus1 = Console.ReadLine();
                // Tarkista onko vastaus oikea tyyppiä
                int vastaus1luku;
                oikeaTyyppi = int.TryParse(vastaus1, out vastaus1luku);

                // Boolean opetator AND (ja) &&
                // 1 * 1 =1 true =true && true
                // 1 * 0 = 0 false = false && true
                // 0 * 1 = 0 false
                // 0 * 0 = 0 false

                if (oikeaTyyppi && vastaus1luku == 4)
                {
                    //Jos vastaus on oikein, lisää piste
                    pisteet = pisteet + 1;
                }


                /*if (oikeaTyyppi)
                {
                    // oikeaa tyyppiä!
                    if (vastaus1luku == 4)
                    {
                        pisteet = pisteet + 1;
                    };
                } */

                // jos vastaus on väärää tyypiä, esitä kysymys uudestaan
                // Looginen operaattori NOT (ei, negaatio) ! (shift + 1)
                //false -> true
                // true -> false

            } while (!oikeaTyyppi); // oikeaTyyppi == false
            //while (oikeaTyyppi == false);


            Console.Clear();
            Console.WriteLine("Pisteiden määrä on " + pisteet);
            Console.WriteLine("Mikä on Suomen pääkaupunki?");
            string vastaus2 = Console.ReadLine();
            if (vastaus2.ToLower() == "helsinki" || vastaus2.ToLower() == "hesa")

            //
            {
                pisteet += 1;

            }

            Console.Clear();
            Console.WriteLine("Pisteiden määrä on " + pisteet);
            Console.WriteLine("Mikä on Suomen pisin joki?");
            string vastaus3 = Console.ReadLine();
            if (vastaus3.ToLower() == "kemijoki") ;
            if (vastaus3 == "Kemijoki" || vastaus3 == "kemijoki")
            //
            {
                pisteet += 1;
            }

            Console.Clear();
            Console.WriteLine("Pisteiden määrä on " + pisteet);
            Console.WriteLine("Mikä on Suomen suurin järvi?");
            string vastaus4 = Console.ReadLine();
            if (vastaus4.ToLower() == "saimaa") ;
            if (vastaus4 == "Saimaa" || vastaus4 == "saimaa")
            //
            {
                pisteet += 1;
            }

            Console.Clear();
            Console.WriteLine("Pisteiden määrä on " + pisteet);
            Console.WriteLine("Mikä on Suomen korkein vuori?");
            string vastaus5 = Console.ReadLine();
            if (vastaus5.ToLower() == "halti") ;
            if (vastaus5 == "Halti" || vastaus5 == "halti")
            //
            {
                pisteet += 1;
            }

            Console.Clear();
            // Kun kaikki kysymykset on kysytty, näytä pisteiden määrä.
            Console.WriteLine("Pisteiden määrä on " + pisteet);

            // Murtoluku
            Console.WriteLine("Mikä on pii kahdella desimaalilla?");
            // 3.14 <- englanniksi
            // 3,14 <- suomeksi
            float piiFloat;
            CultureInfo suomi = new CultureInfo("fi-FI");
            CultureInfo englanti = new CultureInfo("en-Us");
            do
            {
                string piiVastaus = Console.ReadLine();
                oikeaTyyppi = float.TryParse(piiVastaus, suomi, out piiFloat);
                if (oikeaTyyppi == false)
                {
                    oikeaTyyppi = float.TryParse(piiVastaus, englanti, out piiFloat);
                }
                if (oikeaTyyppi)
                {
                    // Käytetään vaihteluväliä oikean vastauksen tarkistamiseen
                    // if (piiFloat == 3.14 ) // Tähän aina englanniksi
                    if (Math.Abs(piiFloat - 3.14f) < 0.01f) // Tarkkuus 0.01
                    //if (piiVastaus == "3,14" || piiVastaus == "3.14")
                    {
                        pisteet += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Anna murtoluku!");
                }
            } while (oikeaTyyppi == false);

            // Kun kaikki kysymykset on kysytty, näytä pisteiden määrä.
            Console.WriteLine("Pisteiden määrä on " + pisteet);

            // Vaikea kysymys, saa yritt'' 3 kertaa
            // Muuttuja sille kuinka monta kertaa on yrittänyt
            int yrityksiäJäljellä = 3;
            bool tarkoitusOikein = false;
            do
            {
                Console.WriteLine("Mikä on elämän tarkoitus?");
                string tarkoitusVastaus = Console.ReadLine();

                tarkoitusOikein = tarkoitusVastaus == "onni";
                if (tarkoitusOikein)
                {
                    pisteet += 3;
                }
                else
                {
                    yrityksiäJäljellä -= 1;
                    Console.WriteLine("Väärin, yritä uudestaan. " + yrityksiäJäljellä + " yritystä jäljellä.");
                }
                // Niin kauan kuin vastaus on väärin (eli ei ole oikein) ja
                // yrityksiä on enemmän kuin 0; kysy uudestaan
            }
            while (!tarkoitusOikein && yrityksiäJäljellä > 0);

            // Kun kaikki kysymykset on kysytty, näytä pisteiden määrä.
            Console.WriteLine("Pisteiden määrä on " + pisteet);

            // Sama kysymys käyttäen fr -luuppia
            // alkutilanne  ; ehto(alussa ja lopussa); kierroksen jälkeen 
            for (int yrityksiä = 3; yrityksiä > 0; yrityksiä -= 1)
            {
                Console.WriteLine("Vielä. Mikä on elämän tarkoitus?");
                string vastaus = Console.ReadLine();
                if (vastaus == "onni")
                {
                    pisteet += 1;
                    break; // Lopeta luupi kesken
                }
                else
                {
                    Console.WriteLine("Väärin " + (yrityksiä - 1) + " yritystä jäljellä");
                }
            }
            // break vie tänne

            // Kun kaikki kysymykset on kysytty, näytä pisteiden määrä.
            Console.WriteLine("Pisteiden määrä on " + pisteet);

            // Jos vastaus on väärää tyyppiä, esitä kysymys uudestaan
            // Tarkista onko vastaus oikein  vain väärin
            // Jos vastaus on oikein, lisää pisteisiin 1 ja mene suoraavaan kysymykseen
            // Jos vastaus on väärin, mene seuraavaan kysymykseen
            // Esitä kysymys 2 ja niin edeleeen...
        }
    }
}

// Ensi keralla;
// Jokainenkysymys tarvitsee paljon koodia, mutta rakenne on aina sama. 
// Eikö olisi helppoa jos voisi käyttää samaa koosia uudestaan vaikka näin:
/* 
pisteet += TeeKysymys ("Mikä on Suomen pituus", 5000);
pisteet += TeeKysymys ("Mikä on Ruotsin pääkaupunki", "Tukholma");
*/