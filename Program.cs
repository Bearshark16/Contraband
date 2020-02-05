using System;
using System.Collections.Generic;

namespace Contraband
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Car> cars = new List<Car>();

            string input = "";
            int x = 0;
            int y = 0;
            int z = 0;

            bool result;

            Console.WriteLine("Hur många bilar ska skapa?\n");
            Input(out input, out x);

            for (int i = 0; i < x; i++)
            {
                y = random.Next(1, 11);

                if (y >= 5)
                {
                    cars.Add(new CleanCar());
                }
                else if (y < 5)
                {
                    cars.Add(new ContrabandCar());
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Vilken bil vill du titta på?\n");
                Input(out input, out x);
                while (x > cars.Count || x <= 0)
                {
                    Input(out input, out x);
                }
                if (cars[x-1].alreadyChecked)
                {
                    Console.WriteLine("Den bilen har du redan tittat på!");
                }
                else
                {
                    result = cars[x-1].Examine();

                    if (result)
                    {
                        Console.WriteLine("Det finns contraband i den här bilen!");
                    }
                    else
                    {
                        Console.WriteLine("Den här bilen är ren");
                    }
                }

                Console.ReadLine();
            }
        }

        private static void Input(out string input, out int x)
        {
            Console.Write("> ");
            input = Console.ReadLine();
            while (!int.TryParse(input, out x) && x <= 0)
            {
                Console.Write("> ");
                input = Console.ReadLine();
            }
        }
    }
}
