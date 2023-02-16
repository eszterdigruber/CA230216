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
            var sr = new StreamReader(@"hegyekMoSorok.txt");
        }
    }
}