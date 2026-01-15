namespace Terningespil
{
    public class Count
    {
        private static int AmountOfSix = 0;
        private static int AmountOfSixDuringRun = 0;

        public static void ThrowCounter()
        {
            AmountOfSix++;
            AmountOfSixDuringRun++;
        }

        public static void ResetAmountOfSix()
        {
            AmountOfSixDuringRun = 0;
        }

        public static void SixCounter()
        {
            Console.WriteLine($"You have rolled a six {AmountOfSix} times \nDuring this round you got {AmountOfSixDuringRun} sixes");
        }
    }
}
