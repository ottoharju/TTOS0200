using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab07
    {
        public class Opiskelija

            static void Testaa()
        {
            {

                //luodaan List-tyyppinen lista opiskelijoista
                List<Opiskelija> opiskelijat = new List<Opiskelija>()
                //testin vuoksi erilaisia tapoja lisätä olioita Listaan
                Opiskelija masa = new Opiskelijat("Masa, Niemi");
                opiskelijat.Add(masa);
                opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1234"));
                //myös näin
                opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H5678" });
                opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testaaja", AsioID = "T9876", Ryhmä="TTV17S1" });
                Opiskelija kalle = new Lab07.Opiskelija();
                kalle.Etunimi = "Kalle"; kalle.Sukunimi = "Ankka"; kalle.AsioID = "K6677"; opiskelijat.Add(kalle);
                //yhden opiskelijan tietojen näyttäminen
                Console.WriteLine("Anna numero väliltä 1-{0}", opiskelijat.Count);
                int i = int.Parse(Console.ReadLine());
                if (i > opiskelijat[i - 1].ToString());
                else
                    Console.WriteLine("MiniASIOssa on vain {0} opiskelijaa", opiskelijat);
                Console.WriteLine("MiniASIOn {0} opiskelija on {1}", i, opiskelijat[i]);
                //kaikkien opiskelijoiden tiedot
                Console.WriteLine("MiniASIOn kaikki opiskelijat");
                foreach (var o in opiskelijat)
                {
                    Console.WriteLine(o.ToString());
                    //kaikkien opiskelijoiden tiedot aakkosjärjestyksessä s
                }
            }


            #region PROPERTIES
            public string Etunimi { get; set; }
            public string Sukunimi { get; set; }
            public string AsioID { get; set; }
            public string Ryhma { get; set; }

            #endregion
            #region CONSTRUCTORS
            public Opiskelija()
            { }
            public Opiskelija(string etunimi, string sukunimi)
            {
                Etunimi = etunimi;
                Sukunimi = sukunimi
             {

                }
            }

            #endregion

            #region METHODS
            public override string ToString()
            {
                return string.Format("{0} {1} {2} {3}"),
                Etunimi, Sukunimi, AsioID, Ryhmä);

            }
            #endregion 
        }
            }
        }

    
