namespace Terningespil
{
    public class Throw
    {
        public static void Main()
        {
            Console.WriteLine("How many dice would you like to roll? (1-9)");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int numberOfDice) || numberOfDice < 1 || numberOfDice > 9)
            {
                Console.WriteLine("Invalid input. Rolling 1 die by default.");
                numberOfDice = 1;
            }

            Random rnd = new Random();
            int[] diceRolls = new int[numberOfDice];
            bool allSixes = false;
            int attempts = 0;

            Console.WriteLine($"\nTrying to roll all {numberOfDice} dice as sixes...\n");

            while (!allSixes)
            {
                attempts++;
                int total = 0;
                allSixes = true;

                Console.WriteLine($"Attempt #{attempts}:");
                for (int i = 0; i < numberOfDice; i++)
                {
                    diceRolls[i] = rnd.Next(1, 7);
                    Console.WriteLine($"  Die {i + 1} rolled: {diceRolls[i]}");
                    total += diceRolls[i];

                    if (diceRolls[i] != 6)
                    {
                        allSixes = false;
                    }
                }

                if (numberOfDice > 1)
                {
                    Console.WriteLine($"  Total: {total}");
                }

                if (!allSixes)
                {
                    Console.WriteLine("  \nNot all sixes, rolling again...\n");
                }
            }

            Console.WriteLine($"\nAll {numberOfDice} dice showed 6! \nIt took {attempts} attempt(s).\n");
            
 
            Count.ThrowCounter();

            Replay.ReplayGame();
        }
    }
}
