using System;

namespace Papier__kamień__nożyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(1, 3);

            int guess = 0;
            Console.WriteLine("Gra Papier, kamień i nożyce.");
            Console.WriteLine("Ile razy chesz zagrać?");
            int user = int.Parse(Console.ReadLine());
            

            for (int j = 1; j <= user; j++)
            {

                Console.WriteLine();
                Console.WriteLine("Wybierz 1 - papier, 2 - kamień, 3 - nożyce");
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine();
              
                if (i == guess)
                {                  
                    Console.WriteLine($"Gracz {i} i A.I. {i} dokonali takiego samego wyboru.");
                }
                else if (i == 1 && guess == 2)
                {
                    Console.WriteLine($"A.I wybrało {i} papier a gracz kamień! Wygyrwa A.I.");
                }
                else if (i == 1 && guess == 3)
                {
                    Console.WriteLine($"A.I wybrało {i} papier a gracz nożyce! Wygrywa Gracz");
                }
                else if (i == 2 && guess == 1)
                {
                    Console.WriteLine($"A.I wybrało {i} kamień a gracz papier! Wygyrwa Gracz");
                }
                else if (i == 2 && guess == 3)
                {
                    Console.WriteLine($"A.I wybrało {i} kamień a gracz nożyce! Wygyrwa A.I");
                }
                else if (i == 3 && guess == 2)
                {
                    Console.WriteLine($"A.I wybrało {i} nożyce a gracz kamień! Wygyrwa A.I.");
                }
                else if (i == 3 && guess == 1)
                {
                    Console.WriteLine($"A.I wybrało {i} nożyce a gracz kamień! Wygyrwa Gracz");
                }
            }
        }
    }
}
