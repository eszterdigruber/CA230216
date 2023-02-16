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
            Feladat2Beolvasas();
            Feladat4AtlagMag();
        }

        private static void Feladat4AtlagMag()
        {
            Console.WriteLine("4.Felaat: átlag, magasság");
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
            Console.WriteLine("2.Feladat: beolvasás");
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