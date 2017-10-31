using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab08
    {
        public class Tehtava1
        {
            public static void TestaaTehtava1()
            {
                //KÄYTTÄKÄÄ AINA TRY-CATCHIA
                try
                {
                    string nimi;
                    string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); /*kovakoodattu versio, ei hyvä: @"D:\K8183";*/
                    string filu = filupath + @"\testi.txt";
                    //kirjoitetaan käyttäjän antamat rivit tiedostoon
                    //luodaan StreamWriter tyyppinen olio johon kirjoitetaan
                    StreamWriter sw = new StreamWriter(filu);
                    do
                    {
                        Console.Write("Anna nimi (Enter lopettaa)");
                        nimi = Console.ReadLine();
                        if (nimi.Length > 0)
                            sw.WriteLine(nimi);
                    } while (nimi.Length != 0);
                    sw.Close();
                    //avataan tiedosto uudestaan (kunhan on tarkistettu että onko tiedosto olemassa) ja luetaan sen sisältö ja näytetään konsolissa
                    if (File.Exists(filu))
                    {
                        string teksti = File.ReadAllText(filu);
                        Console.WriteLine(teksti);
                    }

                }

                //halutessaan voi lisätä yksittäisten virheiden käsittelyn
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Tiedostoa ei löydy");
                }

                //normaalisti tämä riittää
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public class Tehtava2
        {
            public static void TestaaTehtava2()
            {
                try
                {
                    string filupath = @"D:\Temp";
                    string filu = filupath + @"\nimet.txt";
                    if (File.Exists(filu))
                    {
                        int nimet = 0;
                        List<string> teksti = File.ReadAllLines(filu).ToList();
                        var q = teksti.GroupBy(x => x)
                            .Select(g => new { Value = g.Key, Count = g.Count() });

                        foreach (var x in q)
                        {
                            nimet++;
                        }

                        Console.WriteLine("Löytyi {0} riviä, ja {1} nimeä", teksti.Count(), nimet);
                        foreach (var x in q)
                        {
                            Console.WriteLine("Nimi " + x.Value + " esiintyy " + x.Count + " kertaa");
                        }

                        teksti.Sort();

                        Console.WriteLine("\nLöytyi {0} riviä, ja {1} nimeä sortattuna", teksti.Count(), nimet);
                        foreach (var x in q)
                        {
                            Console.WriteLine("Nimi " + x.Value + " esiintyy " + x.Count + " kertaa");
                        }
                    }
                }

                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Tiedostoa ei löydy");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}