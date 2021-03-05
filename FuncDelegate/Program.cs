using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ID = 1, Name = "Tamim"},
                new Employee{ID = 1, Name = "Arefin"},
                new Employee{ID = 1, Name = "Anik"},
            };

            Func<Employee, string> selector = employee => "Name : " + employee.Name;

            IEnumerable<string> names = listEmployees.Select(selector);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Another Example with two input parameters
            Func<int, int, string> funcDelegate = (x, y) => "Sum is : " + (x + y).ToString();

            string result = funcDelegate(10, 20);
            Console.WriteLine(result);
        }
    }
}
