namespace _01._Count_Chars_in_a_String_SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> characters = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    continue;
                }

                if (characters.ContainsKey(c))
                {
                    characters[c]++;
                }
                else
                {
                    characters.Add(c, 1);
                }

            }

            foreach (KeyValuePair<char, int> pair in characters)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}