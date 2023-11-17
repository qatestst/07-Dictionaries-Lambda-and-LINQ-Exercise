namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();
            List<char> chars = new List<char>();

            foreach (string s in input)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    chars.Add(s[i]);
                }
            }

            Dictionary<char, int> dictForChars = new Dictionary<char, int>();

            foreach (char c in chars)
            {
                if (dictForChars.ContainsKey(c))
                {
                    dictForChars[c] += 1;
                }
                else
                {
                    dictForChars.Add(c, 1);
                }
            }

            foreach (KeyValuePair<char, int> pair in dictForChars)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}