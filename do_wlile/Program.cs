using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tulostaa lauseen konsoliin
            Console.WriteLine("Moi!");
            // Luo kokonaislukumuuttuja testi
            int testi;
            // Anna sen arvoksi luku 56
            testi = 56;
            // Tulostaa lauseen konsoliin
            Console.WriteLine(testi);

            // Tulkitse vastaus kokonaisluvuksi ja tallenna muuttujaan luku
            // Luo uusi kokonaislukumuuttuja, anna sen nimeksi luku. Sijoita siihen / anna sen arvoksi
            // se mitä Convert-luokan funksio ToInt32() palauttaa kun sille annetaan parametriksi muuttujan vastaus sisältö
            // int luku = Convert.ToInt32(vastaus);
            bool onnistui; // Pitää olla olemAA ennen do-while lohkoa
            do
            {
                // Tulostaa lauseen konsoliin
                Console.WriteLine("Annaluku");
                // Lukee tietoa konsolista
                string vastaus = Console.ReadLine();
                // Sama, mutta käytetään funktiota int.Parse
                //int luku = int.Parse(vastaus);
                // Sama, mutta käytetään funktioita int.Tryparse() joille annetaan parametriksi myös kohdemuuttuja
                int luku;
                onnistui = int.TryParse(vastaus, out luku); // true tai false
                if (onnistui)
                {
                    Console.WriteLine("Annoit luvun " + luku);
                }
                else
                {
                    Console.WriteLine("Virhe! Anna kunnollinen luku!");
                }
                Console.WriteLine("Loppu");
            } while (onnistui == false); // jos while (true) -> palaa kohtaan do
        }
    }
}
