using System;

namespace NumbersGame
{
    class Program
    {
        static void GuessCheck()
        {
            Random random = new Random();
            int generatedNumber = random.Next(1, 20);

            //int generatedNumber = 10;

            for (int i = 0; i < 5; i++)
            {
                int userGuess = Int32.Parse(Console.ReadLine());
                
                if(userGuess == generatedNumber)
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    break;

                } else if(userGuess > generatedNumber)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                } else
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                
                if (i == 4)
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                } else
                {
                    Console.WriteLine("Försök igen");
                }
            }
            }


        static void Main()
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            GuessCheck();
        }
        }
}

