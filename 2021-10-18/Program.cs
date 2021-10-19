using System;

namespace _2021_10_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            string senasteVinnaren = "Ingen har vunnit än";
            string menyVal = "0";
            while (menyVal != "4")
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Spela Gissa talet");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Visa spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                menyVal = Console.ReadLine();

                Console.WriteLine();

                switch (menyVal)
                {
                    case "1":
                        string str;
                        int nummer;

                        Random randomerare = new Random();
                        int slump_tal = randomerare.Next(min, max);

                        Console.WriteLine("Gissa på ett tal mellan 1 till 10 och ange det i siffror!");
                        str = Console.ReadLine();
                        nummer = int.Parse(str);

                        while (nummer != slump_tal)
                        {
                            if (nummer < slump_tal)
                            {
                                Console.WriteLine("Du gissade för lågt!");
                                Console.WriteLine("Gissa igen!");
                                str = Console.ReadLine();
                                nummer = int.Parse(str);
                            }
                            else if (nummer > slump_tal)
                            {
                                Console.WriteLine("Du gissade för högt!");
                                Console.WriteLine("Gissa igen");
                                str = Console.ReadLine();
                                nummer = int.Parse(str);
                            }

                        }

                        Console.WriteLine("Grattis! Du gissade rätt");
                        break;

                    case "2":
                        Console.WriteLine($"Senaste vinnaren: {senasteVinnaren}");
                        break;
                    case "3":
                        Console.WriteLine("Målet med spelet är att du ska välja mellan talen 1-10");
                        Console.WriteLine("Du ska försöka gissa rätt tal");
                        Console.WriteLine("Datorn väljer ett tal mellan 1-10. Du ska med hjälp av tur gissa rätt");
                        Console.WriteLine("Det kommer stå om din gissning är för hög eller för låg");
                        break;
                   
                    case "4":
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;


                }
                Console.WriteLine();
            
          
            }
        }
    }
}
