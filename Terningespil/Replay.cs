using System;
using System.Collections.Generic;
using System.Text;

namespace Terningespil
{
    public class Replay
    {
        public static void ReplayGame()
        {
            while (true)
            {
                Console.WriteLine("Try again? (y) \nExit? (e) \nStats? (s)");
                string input = Console.ReadLine();
                
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid choice, please type 'y', 'e' or 's'.");
                    continue;
                }
                
                char userChoice = input[0];
                if (userChoice == 'y')
                {
                    Count.ResetAmountOfSix();
                    Throw.Main();
                    break;
                }
                else if (userChoice == 's')
                {
                    Count.SixCounter();
                }
                else if (userChoice == 'e')
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please type 'y', 'e' or 's'.");
                }
            }
        }
    }
}
