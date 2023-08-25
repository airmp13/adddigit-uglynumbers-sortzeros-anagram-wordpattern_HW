namespace WordPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern, s;

            Console.WriteLine("Enter Pattern: ");
            pattern=Console.ReadLine();
            Console.WriteLine("Enter Words with Space between: ");
            s = Console.ReadLine();

            Console.WriteLine("Entered Words Validation with Pattern is: {0}", WordPattern(pattern, s));
        }

        public static bool WordPattern(string pattern, string s)
        {
            Dictionary<char,string> dict = new Dictionary<char,string>();
            int i = 0;
            string[] words = s.Split(' ');

            foreach (char c in pattern)
            {
                
                if (dict.ContainsKey(c))
                {
                    if (dict[c] == words[i]) dict[c].Trim();
                    else return false;
                }
                else dict.Add(c, words[i]);
                i++;
            }

            return true;
        }
    }
}