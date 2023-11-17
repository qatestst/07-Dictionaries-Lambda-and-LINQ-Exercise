namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArray = Console.ReadLine().Split().ToArray();

                string command = commandArray[0];
                string employee = commandArray[1];

                if (command == "register")
                {

                    string plateNumber = commandArray[2];

                    if (!register.ContainsKey(employee))
                    {
                        register.Add(employee, plateNumber);
                        Console.WriteLine($"{employee} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {register[employee]}");
                    }
                }
                else if (command == "unregister")
                {

                    if (register.ContainsKey(employee))
                    {
                        register.Remove(employee);
                        Console.WriteLine($"{employee} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {employee} not found");
                    }
                }
            }

            foreach (KeyValuePair<string, string> pair in register)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}