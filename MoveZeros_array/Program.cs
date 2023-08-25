namespace MoveZeros_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



            Console.WriteLine("Enter number of inputs: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} numbers: ", n);

            int[] nums = new int[n] ;

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i);
                nums[i] = Convert.ToInt32(Console.ReadLine());

            }

            MoveZeros(nums);


        }


        public static void MoveZeros(int[] nums) 
        {
            for (int i = 0;i < nums.Length;i++) 
            {
                if (nums[i] == 0)
                {
                    for(int j=i ;j < nums.Length-1;j++)
                    {
                        nums[j] = nums[j + 1];

                    }
                    nums[nums.Length-1] = 0;
                }
            }
            
            foreach (int i in nums)
            {
                Console.Write(i + ",");
            }
        
        }
    }
}