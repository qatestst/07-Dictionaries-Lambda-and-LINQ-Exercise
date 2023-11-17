namespace _06._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, List<string>> companyEmployee = new Dictionary<string, List<string>>();


            while (input != "End")
            {
                string companyName = input.Split(" ")[0];
                string employeeID = input.Split(" ")[2];

                if (!companyEmployee.ContainsKey(companyName))
                {
                    companyEmployee.Add(companyName, new List<string>());
                    companyEmployee[companyName].Add(employeeID);
                }
                else
                {
                    if (!companyEmployee[companyName].Contains(employeeID))
                    {
                        companyEmployee[companyName].Add(employeeID);
                    }
                }

                input = Console.ReadLine();
            }


            foreach (KeyValuePair<string, List<string>> pair in companyEmployee)
            {
                Console.WriteLine($"{pair.Key}");

                foreach (string id in pair.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }

        }

    }
}