namespace ListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "John", 5000);
            Employee emp2 = new Employee(102, "Anne", 7000);
            Employee emp3 = new Employee(103, "Mark", 3000);

            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            employees.Insert(1, emp3);
            employees.Remove(emp3);

            foreach (Employee emp in employees)
                Console.WriteLine(emp + "\n");


            // Search

            // IndexOf
            int index = employees.IndexOf(emp1);

            if (index >= 0)
                Console.WriteLine("It exists");
            else
                Console.WriteLine("Doesn't exist");


            // Contains
            if (employees.Contains(emp1))
                Console.WriteLine("It exists");
            else
                Console.WriteLine("Doesn't exist");


            // Exists
            if (employees.Exists(e => e.Name
                                       .ToUpper()
                                       .StartsWith("A")))
                Console.WriteLine("It exists");
            else
                Console.WriteLine("Doesn't exist");


            // Find
            var em = employees.Find(e => e.Salary > 4000);

            if (em != null)
                Console.WriteLine(em);
            else
                Console.WriteLine("Doesn't exist");
        }
    }
}
