namespace AddDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Digit: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Output: {0}",AddDigits(digit));
        }

        public static int AddDigits(int digit)
        {
            if (digit < 10) return 0;
            else
            {
                while (true)
                {
                    digit = digit % 10 + digit / 10;
                    if (digit < 10) return digit;
                }
            }
   
        }
    }
}