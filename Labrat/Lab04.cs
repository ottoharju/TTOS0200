using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab0405
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
                        Console.WriteLine(OnkoLuku(""));
                        Console.WriteLine(" ");
                        Console.WriteLine(OnkoPvm(""));
                        Console.WriteLine(" ");
                    }
                }

            }
        }
        public class Hissi
        {
            public int TamaKerros { get; set; }

            public Hissi()
            {
                this.TamaKerros = TamaKerros;
                this.UusiKerros = UusiKerros;
            }

            private int uusikerros = 1;
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

        public class Tehtava4
        {
            class Employee
            {
                public string Name { get; set; }
                public string Profession { get; set; }
                public int Salary { get; set; }

                public Employee()
                {
                }

                public Employee(string name, string profession, int salary)
                {
                    Name = name;
                    Profession = profession;
                    Salary = salary;
                }
                public override string ToString()
                {
                    return "Name: " + Name + " Profession: " + Profession + " Salary: " + Salary;
                }
            }

            class Boss : Employee
            {
                public string Car { get; set; }
                public int Bonus { get; set; }

                public Boss()
                {
                }

                public Boss(string name, string profession, int salary, string car, int bonus)
                    : base(name, profession, salary)
                {
                    Car = car;
                    Bonus = bonus;
                }

                public override string ToString()
                {
                    return base.ToString() + " Car: " + Car + " Bonus: " + Bonus;
                }
            }

            public static void TestClasses()
            {
                Employee employee = new Employee();
                employee.Name = "Taneli";
                employee.Profession = "Muurari";
                employee.Salary = 2600;
                Console.WriteLine("Employee:");
                Console.WriteLine(employee.ToString());
                Console.WriteLine("");

                Boss bossi = new Boss();
                bossi.Name = "Frederik";
                bossi.Profession = "Operatiivinen Headmaster";
                bossi.Salary = 4800;
                bossi.Car = "Mersu";
                bossi.Bonus = 600;
                Console.WriteLine("Boss:");
                Console.WriteLine(bossi.ToString());
                Console.WriteLine("");

                employee.Salary = 2900;
                Console.WriteLine("Employee:");
                Console.WriteLine(employee.ToString());


            }

        }

        public class Tehtava5
        {
            class Vehicle
            {
                public string Name { get; set; }
                public string Model { get; set; }
                public int Year { get; set; }
                public string Color { get; set; }

                public Vehicle()
                {
                }

                public Vehicle(string name, string model, int year, string color)
                {
                    Name = name;
                    Model = model;
                    Year = year;
                    Color = color;
                }

                public override string ToString()
                {
                    return "Name: " + Name + " Model: " + Model + " ModelYear: " + Year + " Color: " + Color;
                }
            }

            class Bike : Vehicle
            {
                public bool Gear { get; set; }
                public string GearName { get; set; }

                public Bike()
                {
                }

                public Bike(string name, string model, int year, string color, bool gear, string gearname)
                    : base(name, model, year, color)
                {
                    Gear = gear;
                    GearName = gearname;
                }

                public override string ToString()
                {
                    return base.ToString() + " GearWheels: " + Gear + " GearName: " + GearName;
                }


            }

            class Boat : Vehicle
            {
                public string BoatType { get; set; }
                public int SeatCount { get; set; }

                public Boat()
                {
                }

                public Boat(string name, string model, int year, string color, string boattype, int seatcount)
                    : base(name, model, year, color)
                {
                    BoatType = boattype;
                    SeatCount = seatcount;
                }

                public override string ToString()
                {
                    return base.ToString() + " BoatType: " + BoatType + " SeatCount: " + SeatCount;
                }

            }

            public static void TestClasses()
            {
                Bike bike1 = new Bike();
                bike1.Name = "Jopo";
                bike1.Model = "Street";
                bike1.Year = 2012;
                bike1.Color = "Blue";
                bike1.Gear = false;
                bike1.GearName = "";
                Console.WriteLine("Bike 1 info:");
                Console.WriteLine(bike1.ToString());
                Console.WriteLine("");

                Bike bike2 = new Bike();
                bike2.Name = "Yosemite";
                bike2.Model = "Mountain";
                bike2.Year = 1999;
                bike2.Color = "Black";
                bike2.Gear = true;
                bike2.GearName = "Biltema";
                Console.WriteLine("Bike 2 info:");
                Console.WriteLine(bike2.ToString());
                Console.WriteLine("");

                Boat boat1 = new Boat();
                boat1.Name = "Flipper";
                boat1.Model = "305d";
                boat1.Year = 1988;
                boat1.Color = "White";
                boat1.BoatType = "Motorboat";
                boat1.SeatCount = 9;
                Console.WriteLine("Boat 1 info:");
                Console.WriteLine(boat1.ToString());
                Console.WriteLine("");

                Boat boat2 = new Boat();
                boat2.Name = "Terhi";
                boat2.Model = "375";
                boat2.Year = 1995;
                boat2.Color = "Brown";
                boat2.BoatType = "Rowboat";
                boat2.SeatCount = 3;
                Console.WriteLine("Boat 2 info:");
                Console.WriteLine(boat2.ToString());
                Console.WriteLine("");

            }
        }

        public class Radio
        {
            public bool Power { get; set; }

            public Radio()
            {
            }

            private int volume;
            public int Volume
            {
                get
                {
                    return volume;
                }
                set
                {
                    if (value >= 0 && value <= 9)
                    {
                        volume = value;
                    }
                    else if (value < 0)
                    {
                        Console.WriteLine("Asetetaan volume minimiin: 0");
                        volume = 0;
                    }
                    else if (value > 9)
                    {
                        Console.WriteLine("Asetetaan volume maksimiin: 9");
                        volume = 9;
                    }
                }
            }

            private double frequency;
            public double Frequency
            {
                get
                {
                    return frequency;
                }
                set
                {
                    if (value >= 2000 && value <= 26000)
                    {
                        frequency = value;
                    }
                    else if (value < 2000)
                    {
                        Console.WriteLine("Asetetaan taajuus minimiin: 2000");
                        frequency = 2000;
                    }
                    else if (value > 9)
                    {
                        Console.WriteLine("Asetetaan taajuus maksimiin: 26 000");
                        frequency = 26000;
                    }
                }
            }
            public int SetVolume()
            {
                Console.Write("Anna uusi äänenvoimakkuus (0-9) > ");
                Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Volume on nyt " + Volume);
                return Volume;
            }

            public double SetFrequency()
            {
                Console.Write("Anna uusi taajuus 2000.0 - 26000.0 > ");
                Frequency = double.Parse(Console.ReadLine());
                Console.WriteLine("Taajuus on nyt " + Frequency);
                return Frequency;
            }
            public bool SetPower()
            {
                do
                {
                    Console.Write("Laitatko radion päälle? 1=Päälle, 0=Pois > ");
                    int number = int.Parse(Console.ReadLine());
                    if (number == 1)
                    {
                        Console.WriteLine("Radio on päällä");
                        Power = true;
                    }
                    else if (number == 0)
                    {
                        Console.WriteLine("Radio on pois päältä");
                        Power = false;
                    }

                    else
                    {
                        Console.WriteLine("Väärä komento");
                    }
                } while (Power != true);
                return Power;

            }

            public static void TestRadio()
            {
                Radio yamaha = new Radio();
                yamaha.SetPower();
                while (yamaha.Power == true)
                {
                    Console.WriteLine("Valitse toiminto: 1: Aseta volume. 2: Aseta taajuus. 0: Sammuta radio");
                    int number = int.Parse(Console.ReadLine());
                    if (number == 1)
                    {
                        yamaha.SetVolume();
                    }
                    else if (number == 2)
                    {
                        yamaha.SetFrequency();
                    }
                    else if (number == 0)
                    {
                        yamaha.SetPower();
                    }
                }
            }
        }

        public class Opiskelija
        {
            class Item
            {
                public string Name { get; set; }
                public int Year { get; set; }
                public int Price { get; set; }

                public Item()
                {
                }

                public Item(string name, int year, int price)
                {
                    Name = name;
                    Year = year;
                    Price = price;
                }

                public override string ToString()
                {
                    return "Nimi: " + Name + " Vuosi: " + Year + " Hinta: " + Price + " euroa";
                }

            }

            class Technology : Item
            {
                public string Model { get; set; }
                public double Screen { get; set; }

                public Technology()
                {
                }

                public Technology(string name, int year, int price, string model, double screen)
                    : base(name, year, price)
                {
                    Model = model;
                    Screen = screen;
                }
                public override string ToString()
                {
                    return base.ToString() + " Malli: " + Model + " Näyttö: " + Screen + " tuumaa";
                }
            }

            class Movies : Item
            {
                public int Length { get; set; }

                public Movies()
                {
                }

                public Movies(string name, int year, int price, int length)
                    : base(name, year, price)
                {
                    Length = length;
                }
                public override string ToString()
                {
                    return base.ToString() + " Pituus: " + Length + " minuuttia";
                }
            }

            public static void TestClasses()
            {
                Technology laptop = new Technology();
                laptop.Name = "Lenovo";
                laptop.Year = 2011;
                laptop.Price = 200;
                laptop.Model = "Thinkpad";
                laptop.Screen = 14;
                Console.WriteLine("Kannettavan info:");
                Console.WriteLine(laptop.ToString());
                Console.WriteLine("");

                Technology phone = new Technology();
                phone.Name = "Xiaomi";
                phone.Year = 2015;
                phone.Price = 180;
                phone.Model = "Redmi 3S";
                phone.Screen = 4.5;
                Console.WriteLine("Puhelimen info:");
                Console.WriteLine(phone.ToString());
                Console.WriteLine("");

                Movies movie1 = new Movies();
                movie1.Name = "Star Wars: Episode IV - A New Hope";
                movie1.Year = 1977;
                movie1.Price = 5;
                movie1.Length = 125;
                Console.WriteLine("Elokuva 1:n info: ");
                Console.WriteLine(movie1.ToString());
                Console.WriteLine("");

                Movies movie2 = new Movies();
                movie2.Name = "Star Wars: Episode V - The Empire Strikes Back";
                movie2.Year = 1980;
                movie2.Price = 6;
                movie2.Length = 127;
                Console.WriteLine("Elokuva 2:n info: ");
                Console.WriteLine(movie2.ToString());
                Console.WriteLine("");

                Movies movie3 = new Movies();
                movie3.Name = "Star Wars: Episode VI - Return of the Jedi";
                movie3.Year = 1983;
                movie3.Price = 5;
                movie3.Length = 134;
                Console.WriteLine("Elokuva 3:n info: ");
                Console.WriteLine(movie3.ToString());
                Console.WriteLine("");

            }

        }
    }
}