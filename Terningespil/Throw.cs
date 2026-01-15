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
            int total = 0;

            Console.WriteLine($"\nRolling {numberOfDice} dice:");
            for (int i = 0; i < numberOfDice; i++)
            {
                diceRolls[i] = rnd.Next(1, 7);
                Console.WriteLine($"Die {i + 1} rolled: {diceRolls[i]}");
                total += diceRolls[i];

                if (diceRolls[i] == 6)
                {
                    Count.ThrowCounter();
                }
            }

            if (numberOfDice > 1)
            {
                Console.WriteLine($"Total: {total}");
            }

            Replay.ReplayGame();
        }
    }
}
