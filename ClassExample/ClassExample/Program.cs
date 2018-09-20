using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Fish", "Chips");
            
            Console.WriteLine(a.GetFullName());

            Console.ReadKey();
        }

        class Person
        {
            string fname;
            string lname;

            public string Fname
            {
                get { return fname; }
                set { fname = value; }
            }

            public string Lname
            {
                get { return lname; }
                set { lname = value; }
            }

            public Person(string _fname, string _lname) {
                fname = _fname;
                lname = _lname;
            }

            public string GetFullName()
            {
                return fname + " " + lname;
            }
        }
    }
}
