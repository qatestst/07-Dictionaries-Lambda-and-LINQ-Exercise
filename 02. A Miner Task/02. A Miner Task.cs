namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            int quantity = 0;

            Dictionary<string, int> resourcesQuantity = new Dictionary<string, int>();

            while (resource != "stop")
            {
                quantity = int.Parse(Console.ReadLine());

                if (resourcesQuantity.ContainsKey(resource))
                {
                    resourcesQuantity[resource] += quantity;

                }
                else
                {
                    resourcesQuantity.Add(resource, quantity);
                }

                resource = Console.ReadLine();

            }

            foreach (KeyValuePair<string, int> pair in resourcesQuantity)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}