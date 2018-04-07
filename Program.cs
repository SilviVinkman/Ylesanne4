using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            var loend = new List<DateTime>();
            var d1 = new DateTime(2015, 1, 1);
            var d2 = new DateTime(1944, 12, 13);
            var d3 = new DateTime(1944, 1, 29);
            var d4 = new DateTime(1974, 4, 21);
            var d5 = new DateTime(1970, 12, 31);
            var d6 = new DateTime(1964, 6, 17);
            var d7 = new DateTime(1953, 12, 20);
            var d8 = new DateTime(1987, 2, 13);
            var d9 = new DateTime(1962, 5, 31);
            var d10 = new DateTime(1992, 10, 01);

            //lisa kuupäevade listi. list sorteeri kasvavalt
            loend.Add(d1);
            loend.Add(d2);
            loend.Add(d3);
            loend.Add(d4);
            loend.Add(d5);
            loend.Add(d6);
            loend.Add(d7);
            loend.Add(d8);
            loend.Add(d9);
            loend.Add(d10);
            Console.WriteLine("Loend sorteeritud:");
            loend.Sort();
            for (int i = 0; i < loend.Count; i++)
            {
                Console.WriteLine(loend[i]);
            }
            //https://forums.asp.net/t/1289294.aspx?TimeSpan+Years+and+Months

            var vanus = new List<int>();

            for (int i = 0; i < loend.Count; i++)
            {
                var Age = DateTime.Now - loend[i];
                DateTime aastatevahe = DateTime.MinValue + Age;
                int Years = aastatevahe.Year - 1;

                vanus.Add(Years);
            }
            Console.WriteLine();
            Console.WriteLine("Vanim vanus on " + vanus.Max() + " aastat");
            Console.WriteLine("Aritm keskmine vanus on " + vanus.Average() + " aastat");
            Console.WriteLine("Noorim vanus on " + vanus.Min() + " aastat");

            string date1 = d1.ToString();
            string date2 = d2.ToString();
            string date3 = d3.ToString();
            string date4 = d4.ToString();
            string date5 = d5.ToString();
            string date6 = d5.ToString();
            string date7 = d5.ToString();
            string date8 = d5.ToString();
            string date9 = d5.ToString();
            string date10 = d5.ToString();

            var kuud = new List<int>();
            //for (int i = 0; i < loend.Count; i++)
            {
                //tahan kuupäeva stringid teha tähemärkide array-ks
                //string [] datetähed = new char[] ( date1);
                //  tahan tähtede array-s iga liikme küljest ära kustutada 4 esimest märki (aastaarvud) koma)
                // tahan tähtede array-s iga liikme lõpu küljest ära kustutada koma ja kuupäevad.
                //kuud.Add(Months);
            }
            // tahan loendada kõikide liikmete hulga listis "kuud"
            // tahan selle loenduse tulemuse sorteerida

            Console.WriteLine("Kõige rohkem sünnipäevi on 12. kuus");
            Console.WriteLine("Press any key");
            Console.ReadLine();

        }
    }
}
