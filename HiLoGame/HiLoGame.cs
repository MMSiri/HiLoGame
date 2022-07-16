using System;
using System.Collections.Generic;
using System.Text;

namespace HiLoGame
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;


        public static void Guess(bool higher)
        {
            int newNumber = random.Next(1, MAXIMUM + 1);
            if (higher && newNumber >= currentNumber || !higher && newNumber <= currentNumber)
            {
                Console.WriteLine("You guessed correctly!");
                pot++;
            }
            else
            {
                Console.WriteLine("Too bad. Your guess was incorrect.");
                pot--;
            }
            currentNumber = newNumber;
            Console.WriteLine($"The current number is: {currentNumber}");
        }

        public static void Hint()
        {
            int halfMax = MAXIMUM / 2;
            if (currentNumber >= halfMax) Console.WriteLine($"The number is at least {halfMax}");
            else Console.WriteLine($"The number is at most {halfMax}");
            pot--;
        }

        public static int GetPot()
        {
            return pot;
        }

    }
}
