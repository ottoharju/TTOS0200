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
                Console.Write("Syötä luku: ");
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
        }        public class Tehtava2
        
        public class Hissi

        {

            public int TamaKerros { get; set; }



            public Hissi()

            {

                this.TamaKerros = TamaKerros;

                this.UusiKerros = UusiKerros;

            }



            private int uusikerros=1;

            public int UusiKerros

            {

                get

                {

                    return uusikerros;

                }

                set

                {

                    if (value > 0 && value < 6)

                    {

                        uusikerros = value;

                    }

                    else if (value < 1)

                    {

                        Console.WriteLine("Liian pieni kerros!");

                    }

                    else if (value > 5)

                    {

                        Console.WriteLine("Liian suuri kerros!");

                    }

                }

            }



            public int AsetaKerros()

            {

                Console.Write("Anna uusi kerros (1-5) > ");

                UusiKerros = int.Parse(Console.ReadLine());

                return UusiKerros;

            }



            public void TulostaKerros()

            {

                TamaKerros = UusiKerros;

                Console.WriteLine("Hissi on nyt kerroksessa " + TamaKerros);

            }



            public static void TestiHissi()

            {

                Hissi dynamo = new Hissi();

                while (true)

                {

                    dynamo.TulostaKerros();

                    dynamo.AsetaKerros();

                }

            }

        }



        public class Vahvistin

        {

            public int VolumeNyt { get; set; }

            public Vahvistin()

            {

                this.VolumeNyt = VolumeNyt;

                this.VolumeUusi = VolumeUusi;

            }



            private int volumeuusi;

            public int VolumeUusi

            {

                get

                {

                    return volumeuusi;

                }

                set

                {

                    if (value >= 0 && value <= 100)

                    {

                        volumeuusi = value;

                    }

                    else if (value < 0)

                    {

                        Console.WriteLine("Liian pieni äänenvoimakkuus! Asetetaan minimiin: 0");

                        volumeuusi = 0;

                    }

                    else if (value > 100)

                    {

                        Console.WriteLine("Liian suuri äänenvoimakkuus! Asetetaan maksimiin: 100");

                        volumeuusi = 100;

                    }

                }

            }



            public int AsetaVolume()

            {

                Console.Write("Anna uusi äänenvoimakkuus (0-100) > ");

                VolumeUusi = int.Parse(Console.ReadLine());

                return VolumeUusi;

            }



            public void TulostaVolume()

            {

                VolumeNyt = VolumeUusi;

                Console.WriteLine("Äänenvoimakkuus on nyt asetettu: " + VolumeNyt);

            }



            public static void TestiVahvistin()

            {

                Vahvistin onkyo = new Vahvistin();

                while (true)

                {

                    onkyo.AsetaVolume();

                    onkyo.TulostaVolume();

                }

            }





        }

    }

}