using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
        beginning:
            Random rnd = new Random();
            int random = rnd.Next(1, 11);
            int user = 0;
            bool valid = false;
            int i = 0;
            bool[] array = new bool[10];

            Console.Title = "Zgadnij liczbę";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zgadnij liczbę od 1 do 10");
            Console.ResetColor();

            do
            {
                do
                {
                    Console.WriteLine("Podaj liczbę");
                    valid = int.TryParse(Console.ReadLine(), out user);
                    if (!valid)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Podaj prawidłową liczbę");
                        Console.ResetColor();
                    }
                } while (!valid);

                if (user < 1 || user > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podaj liczbę z zakresu od 1 do 10");
                    Console.ResetColor();
                    continue;
                }

                if (array[user - 1])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podano tą samą liczbę");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    array[user - 1] = true;
                }

                if (user < random)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Podana liczba jest mniejsza od wylosowanej");
                    Console.ResetColor();
                }
                else if (user > random)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Podana liczba jest większa od wylosowanej");
                    Console.ResetColor();
                }
                i++;

            } while (user != random);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo!!! Odgadłaś za {0} razem.", i);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Chcesz zagrać jeszcze raz? Jeśli tak - wpisz TAK, jeśli nie - wpisz NIE");
            Console.ResetColor();
            string answernextgame = Console.ReadLine();
            if (answernextgame == "TAK")
            {
                goto beginning;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("KONIEC GRY. Mam nadzieję, że się podobała!");
                Console.ResetColor();
            }
        }
    }
}
