namespace _05._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new();

            for (int i = 0; i < number; i++) 
            {
                
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(grade);
                    students[studentName].Add(1);
                }
                else
                {
                    students[studentName][0] += grade;
                    students[studentName][1] += 1;
                }
            }

            foreach (KeyValuePair<string, List<double>> pair in students)
            {
                if (pair.Value[0] / pair.Value[1] < 4.5)
                {
                    students.Remove(pair.Key);
                }
                else
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value[0] / pair.Value[1]:F2}");
                }
            }

        }
    }
}