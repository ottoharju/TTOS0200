using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab09
    {
        //Tehtävä 1
        public class Dice
        {
            #region PROPERTIES
            static Random dice = new Random();
            #endregion
            #region CONS1TRUCTORS
            public Dice()
            {

            }
            #endregion
            #region METHODS
            public int ThrowDice()
            {
                int numb = 0;
                numb = dice.Next(1, 7);
                return numb;
            }
            #endregion
            public static void TestDice()
            {
                try
                {
                    List<int> list = new List<int>();
                    Dice d1 = new Dice();
                    Console.WriteLine("Yhden heiton jälkeen");
                    Console.WriteLine("Numerosi oli: {0}", d1.ThrowDice());
                    Console.WriteLine("Kuinka monta kertaa halluut heittää noppaa?");
                    int input = int.Parse(Console.ReadLine());
                    for (int i = 0; i < input; i++)
                    {
                        list.Add(d1.ThrowDice());
                    }
                    Console.WriteLine("Noppaa heitetään nyt {0} kertaa, keskiarvo on {1}.", input, list.Average());
                    var q = list.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() });
                    list.Sort();
                    foreach (var x in q)
                    {
                        Console.WriteLine("Nimi {0} esiintyy {1} kertaa", x.Value, x.Count);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        //Tehtävä 2
        public class Shoppings
        {
            #region PROPERTIES
            string Nimi { get; set; }
            double Hinta { get; set; }
            #endregion
            #region CONSTRUCTORS
            public Shoppings(string nimi, double hinta)
            {
                Nimi = nimi;
                Hinta = hinta;
            }
            #endregion
            #region METHODS
            public override string ToString()
            {
                return "Tuote: " + Nimi + " " + Hinta + " e";
            }
            #endregion
            public static void TestShoppings()
            {
                try
                {
                    List<Shoppings> list = new List<Shoppings>();
                    while (true)
                    {
                        Console.WriteLine("Halluutko lisätä tuotteen? 1 kyllä 0 ei");
                        int input = int.Parse(Console.ReadLine());
                        if (input == 0)
                        {
                            Console.WriteLine("Kaikki tuotteet korissa:");
                            foreach (var item in list)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;
                        }
                        else if (input == 1)
                        {
                            Console.WriteLine("Lissää tuote");
                            Console.Write("Tuotteen nimi: ");
                            string name = Console.ReadLine();
                            Console.Write("Tuotteen hinta: ");
                            double price = double.Parse(Console.ReadLine());
                            list.Add(new Shoppings(name, price));
                        }
                        else
                            Console.WriteLine("Ei käy, kokeile uudelleen");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}