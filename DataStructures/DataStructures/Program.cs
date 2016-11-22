using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class EmployeeComparer : IEqualityComparer<Employee>,
                                    IComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return String.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Employee obj)
        {
            return obj.Name.GetHashCode();
        }

        public int Compare(Employee x, Employee y)
        {
            return String.Compare(x.Name, y.Name);
        }
    }

    public class DepartmentCollection :
        SortedDictionary<string, SortedSet<Employee>>
    {
        public DepartmentCollection Add(string departmentName, Employee employee)
        {
            if (!ContainsKey(departmentName))
            {
                Add(departmentName, new SortedSet<Employee>(new EmployeeComparer()));
            }
            this[departmentName].Add(employee);
            return this; //Note this !! Does it simpler to add many items.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List departments and names in alfabetical order.
            var departments = new DepartmentCollection();

            departments.Add("Sales", new Employee { Name = "Joy" })
                       .Add("Sales", new Employee { Name = "Dani" })
                       .Add("Sales", new Employee { Name = "Dani" });


            departments.Add("Engineering", new Employee { Name = "Scott" })
                       .Add("Engineering", new Employee { Name = "Alex" })
                       .Add("Engineering", new Employee { Name = "Dani" });

            departments.Add("Development", new Employee { Name = "Tor" })
                       .Add("Development", new Employee { Name = "Alex" })
                       .Add("Development", new Employee { Name = "Dani" });


            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine("\t" + employee.Name);
                }
            }

            Console.ReadLine();

            //LESSON: Everyday delegates
            Action<bool> print = d => Console.WriteLine(d);
            Func<double, double> square = d => d * d;
            Func<double, double, double> add = (x, y) => x + y;
            Predicate<double> isLessThanTen = d => d < 10;

            print(isLessThanTen(square(add(3, 5))));


            //LESSON: Use of Extension method, Delegates, Events
            var buffer = new CircularBuffer<double>(capacity: 3);
            buffer.ItemDiscarded += ItemDiscarded;

            ProcessInput(buffer);

            //Use of Converter<>
            var asDates = buffer.Map(d => new DateTime(2016, 1, 1).AddDays(d)); //Built in method for the converter
            foreach (var date in asDates)
            {
                Console.WriteLine(date);
            }

            buffer.Dump(d => Console.WriteLine(d));

            ProcessBuffer(buffer);


            Console.ReadLine();
        }

        static void ItemDiscarded(object sender,
    ItemDiscardedEventArgs<double> e)
        {
            Console.WriteLine("Buffer full. Discarding {0} New item is {1}",
                    e.ItemDiscarded, e.NewItem
                );
        }
        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }

        private static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }

    }
}
