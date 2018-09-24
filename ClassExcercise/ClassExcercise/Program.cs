using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------number 1----------

            //Console.Write("enter the animal name: ");
            //string animalName = Console.ReadLine();

            //Console.Write("enter the animal sound: ");
            //string animalSound = Console.ReadLine();

            //Animal animal = new Animal(animalName, animalSound);

            //Console.WriteLine(animal.AnimalSays());

            //----------number 2----------

            Console.Write("enter the employee's first name: ");
            string employeeFirstName = Console.ReadLine();
            Console.Write("enter the employee's last name: ");
            string employeeLastName = Console.ReadLine();
            Console.Write("enter the employee's annual salary: ");
            double employeeSalary = double.Parse(Console.ReadLine());
            Console.Write("enter the employee's tax rate as a percentage: ");
            double employeeTax = double.Parse(Console.ReadLine());

            Employee employee = new Employee(employeeFirstName, employeeLastName, employeeSalary, employeeTax);

            Console.WriteLine();
            Console.WriteLine($"{employee.firstName} {employee.lastName}");
            Console.WriteLine($"Gross Anual Salary: ${employee.salary:0.00}");
            Console.WriteLine($"Tax Rate: {employee.tax}%");
            Console.WriteLine($"Net Salary: ${employee.NetSalary():0.00}");

            //--------------------
            Console.ReadKey();
        }

        public class Animal
        {
            string name;
            string sound;

            public string Name { private get { return name; } set { name = value; } }
            public string Sound { get { return sound; } set { sound = value; } }

            public Animal(string _name, string _sound)
            {
                name = _name;
                sound = _sound;
            }

            public string AnimalSays()
            {
                return $"the {name} says {sound}.";
            }
        }

        public class Employee
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public double salary { get; set; }
            public double tax { get; set; }

            public Employee(string _firstName, string _lastName, double _salary, double _tax)
            {
                firstName = _firstName;
                lastName = _lastName;
                salary = _salary;
                tax = _tax;
            }

            public double NetSalary()
            {
                return salary - (salary * (tax / 100));
            }
        }
    }
}
