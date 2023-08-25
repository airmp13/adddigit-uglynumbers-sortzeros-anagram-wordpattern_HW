namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter First Sentence: ");
            string sen1=Console.ReadLine();
            Console.WriteLine("Enter Second Sentence: ");
            string sen2 = Console.ReadLine();

            Console.WriteLine("Validation is : {0}",ValidAnagram(sen1,sen2));


        }


        public static bool ValidAnagram(string sen1,string sen2)
        {
            if (sen1.Length != sen2.Length) return false;
            else
            {
                List<char> sen1_List = sen1.ToList();
                List<char> sen2_List = sen2.ToList();

                sen1_List.Sort();
                sen2_List.Sort();

                if (sen1_List.SequenceEqual(sen2_List)) return true;
  
            } 
            return false; 
        
        }
    }
}