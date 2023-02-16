using System.Text;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        //Lista dinamikusan változó méretű tömb
        //Listában tárolunk
        static List<MoHegyei> MoHegyei_List = new List<MoHegyei>();
        static void Main(string[] args)
        {
            //Magyarország hegyei, soronkénti beolvasás
            Feladat2Beolvasas(); Console.WriteLine("\n---------\n");
            Feladat4AtlagMag(); Console.WriteLine("\n---------\n");
            Feladat5LegMag(); Console.WriteLine("\n---------\n");
            Feladat6Kereses(); Console.WriteLine("\n---------\n");
        }

        private static void Feladat6Kereses()
        {
            Console.WriteLine("6.Feladat: Keresés");
            Console.Write("Kérem adjon meg egy magasságot: ");
            int KeresMqag = int.Parse(Console.ReadLine());

        }

        private static void Feladat5LegMag()
        {
            Console.WriteLine("5.Feladat: Legmagasabb hegy");
            int MaxMag = int.MinValue;
            string MaxHegyNev = "cica";
            string MaxHegyseg = "kutyus";
            foreach (var m in MoHegyei_List)
            {
                if (MaxMag < m.Magassag) 
                { 
                    MaxMag = m.Magassag;
                    MaxHegyNev = m.HegycsucsNeve;
                    MaxHegyseg = m.Hegyseg;
                }
            }
            Console.WriteLine($"\n\tLegmagasabb hegy: {MaxHegyNev} \n\tMagassága: {MaxMag} \n\tHegysége: {MaxHegyseg}");
        }

        private static void Feladat4AtlagMag()
        {
            Console.WriteLine("4.Feladat: Átlag, Magasság");
            int OsszMag = 0;
            foreach (var m in MoHegyei_List)
            {
                OsszMag += m.Magassag;
            }
            double AtlagMag = (double)OsszMag / MoHegyei_List.Count;
            Console.WriteLine($"Hazánk hegyeinek átlag magassága: {AtlagMag:0.00} m");
        }

        private static void Feladat2Beolvasas()
        {
            Console.WriteLine("2.Feladat: Beolvasás");
            var sr = new StreamReader(@"hegyekMoSorok.txt", Encoding.UTF8);
            int db = 0;
            while (!sr.EndOfStream)
            {
                var nev = sr.ReadLine();
                var hegyseg = sr.ReadLine();
                var magassag = sr.ReadLine();
                db++;
                MoHegyei_List.Add(new MoHegyei(nev, hegyseg, magassag));
            }
            sr.Close();
            if (db > 0)
            { Console.WriteLine($"Sikeres beolvasás \nBeolvasott hegyek száma: {db}"); }
            else
            { Console.WriteLine("Sajnos nem sikerült a beolvasás"); }
        }
    }
}