using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab03
    {
        public class Tehtava1
        {
            public static bool OnkoLuku(string syote)
            {
                double number;
                Console.Write("Syotä luku: ");
                syote = Console.ReadLine();
                bool result = double.TryParse(syote, out number);
                Console.Write("Syöte " + syote + " on luku: ");
                return result;

            }
            public static bool OnkoPvm(string syote)
            {
                var dateFormats = new[] { "dd.MM.yyyy", "dd.MM.yy" };
                Console.Write("Anna päivämäärä (pp.kk.vvvv tai pp.kk.vv): ");
                syote = Console.ReadLine();
                DateTime scheduleDate;
                bool result = DateTime.TryParseExact(syote, dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out scheduleDate);
                Console.Write("Syöte " + syote + " on päivämäärä oikeassa muodossa: ");
                return result;
            }

            public class TestiPeti
            {
                public static void Testaus()
                {
                    while (true)
                    {
                        Console.WriteLine(OnkoLuku("3"));
                        Console.WriteLine(" ");
                        Console.WriteLine(OnkoPvm("3"));
                        Console.WriteLine(" ");
                    }
                }

            }
        }
    }
}
