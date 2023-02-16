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
        }

        private static void Feladat2Beolvasas()
        {
            Console.WriteLine("2.Feladat:");
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
        }
    }
}