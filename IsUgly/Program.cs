namespace IsUgly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output: {0}",IsUgly(number));

        }
        public static bool IsUgly(int number)
        {

            
            while (true)
            {
                
                
                    while (number % 2 == 0) number /= 2;
                    while (number % 3 == 0) number /= 3;
                    while (number % 5 == 0) number /= 5;
                    
                    if (number  == 1) return true;

                    else return false;

            }

        }
    }
}