namespace Assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select from the following vehicle models you wish to purchase: \n\t 1) Toyota. \n\t 2) Nissan. \n\t 3) Ford.");
            int makeChoice = Convert.ToInt32(Console.ReadLine());

            switch (makeChoice)
            {
                case 1:
                    Toyota();
                    break;
                case 2:
                    Nissan();
                    break;
                case 3:
                    Ford();
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Select the option you wish to see: \n\t1. Length of Array \n\t2. Sort of Array ");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    LengthArray();
                    break;
                case 2:
                    SortArray();
                    break;
            }

            Console.WriteLine("\t\t\t\t\tEnd of code. Thank you!");

            static void Toyota()
            {
                string[] toyota = { "Tacoma", "Camry", "Tundra" };
                Console.WriteLine("You selected 'Toyota'. Please select the following model you wish to purchase: \n\t 1) Tacoma. \n\t 2) Camry. \n\t 3) Tundra.");
                int toyotaChoice = Convert.ToInt32(Console.ReadLine());

                switch (toyotaChoice)
                {

                    case 1:
                        Console.WriteLine($"You selected the Toyota {toyota[0]}! Nice choice, enjoy!!");
                        break;
                    case 2:
                        Console.WriteLine($"You selected the Toyota {toyota[1]}! Nice choice, enjoy!!");
                        break;
                    case 3:
                        Console.WriteLine($"You selected the Toyota {toyota[2]}! Nice choice, enjoy!!");
                        break;

                }
            }
            static void Nissan()
            {
                string[] nissan = { "Altima", "Titan", "Sentra" };
                Console.WriteLine("You selected 'Nissan'. Please select the following model you wish to purchase: \n\t 1) Altima. \n\t 2) Titan. \n\t 3) Sentra.");
                int nissanChoice = Convert.ToInt32(Console.ReadLine());

                switch (nissanChoice)
                {

                    case 1:
                        Console.WriteLine($"You selected the Nissan {nissan[0]}! Nice choice, enjoy!!");
                        break;
                    case 2:
                        Console.WriteLine($"You selected the Nissan {nissan[1]}! Nice choice, enjoy!!");
                        break;
                    case 3:
                        Console.WriteLine($"You selected the Nissan {nissan[2]}! Nice choice, enjoy!!");
                        break;

                }  
            }
            static void Ford()
            {
                string[] ford = { "Raptor", "Bronco", "Mustang" };
                Console.WriteLine("You selected 'Ford'. Please select the following model you wish to purchase: \n\t 1) Raptor. \n\t 2) Bronco. \n\t 3) Mustang.");
                int fordChoice = Convert.ToInt32(Console.ReadLine());

                switch (fordChoice)
                {

                    case 1:
                        Console.WriteLine($"You selected the Ford {ford[0]}! Nice choice, enjoy!!");
                        break;
                    case 2:
                        Console.WriteLine($"You selected the Forf {ford[1]}! Nice choice, enjoy!!");
                        break;
                    case 3:
                        Console.WriteLine($"You selected the Ford {ford[2]}! Nice choice, enjoy!!");
                        break;

                }
            }
            static void LengthArray()
            {
                string[] ford = { "Raptor", "Bronco", "Mustang" };
                Console.WriteLine(ford.Length);
            }
            static void SortArray()
            {
                string[] ford = { "Raptor", "Bronco", "Mustang" };
                Array.Sort(ford);
                foreach (string car in ford)
                {
                    Console.WriteLine(car);
                }
               
            }
        }
    }
}
