
namespace MoveZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter each number per Line: (enter + to end) ");

            Queue<int> nums = new Queue<int>();
            Queue<int> zeros = new Queue<int>();

            string buf = "";
            int buff ;
            while (true)
            {
                buf = Console.ReadLine();
                if (buf == "+") break;
                else
                {
                    buff = Convert.ToInt32(buf);
                    if (buff == 0) zeros.Enqueue(buff);
                    else nums.Enqueue(buff);
                }
            }

            MoveZeroes(ref nums,ref zeros);

        }

        public static void MoveZeroes(ref Queue<int> nums , ref Queue<int> zeros)
        {
            int numc, zeroc;

            int[] output = new int[nums.Count() + zeros.Count()];
            numc = nums.Count();
            zeroc = zeros.Count();

            for (int i = 0; i < numc; i++)
            {
                output[i] = nums.Dequeue();

            }

            for (int i = numc; i < numc + zeroc; i++)
            {
                output[i] = zeros.Dequeue();
            }

            Console.WriteLine(string.Join(",", output));


        }
    }
}
