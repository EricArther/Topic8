using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car vehicle1 = new Car();
            //vehicle1.Make = "Maker Number1";
            //vehicle1.Model = "MN1OF5";
            //vehicle1.Colour = "Blue";
            //vehicle1.Rego = "12345";

            //Car vehicle2 = new Car();
            //vehicle2.Make = "Maker Number2";
            //vehicle2.Model = "AAAAAAAA";
            //vehicle2.Colour = "Yellow";
            //vehicle2.Rego = "12345";

            //Car vehicle3 = new Car();
            //vehicle3.Make = "Maker Number3";
            //vehicle3.Model = "THISISACAR";
            //vehicle3.Colour = "Black";
            //vehicle3.Rego = "12345";

            //Car vehicle4 = new Car();
            //vehicle4.Make = "Maker Number4";
            //vehicle4.Model = "model name goes here";
            //vehicle4.Colour = "Red";
            //vehicle4.Rego = "12345";

            //Car vehicle5 = new Car();
            //vehicle5.Make = "Steve Rogers";
            //vehicle5.Model = "CARNUMBER5";
            //vehicle5.Colour = "Blue";
            //vehicle5.Rego = "12345";

            //Car[] carli = { vehicle1, vehicle2, vehicle3, vehicle4, vehicle5 };

            //foreach (Car c in carli)
            //{
            //    Console.WriteLine(c.Make);
            //    Console.WriteLine(c.Model);
            //    Console.WriteLine(c.Colour);
            //    Console.WriteLine(c.Rego);
            //    Console.WriteLine();
            //}

            //-------------------

            //Person cap = new Person("Steve", "Rogers", 100);
            //Console.WriteLine($"{cap.Fname} {cap.Lname}, {100} year old");

            //-------------------

            Random random = new Random();

            Animal animal1 = new Animal("Bird", "Chicken",  random.Next(1000, 10000));
            Animal animal2 = new Animal("Fish", "Shark", random.Next(1000, 10000));
            Animal animal3 = new Animal("Insect", "Bee", random.Next(1000, 10000));
            Animal animal4 = new Animal("Bird", "Kiwi", random.Next(1000, 10000));
            Animal animal5 = new Animal("Ape", "DK", random.Next(1000, 10000));

            Animal[] animalli = { animal1, animal2, animal3, animal4, animal5 };

            foreach(Animal a in animalli)
            {
                Console.WriteLine(a.getInfo());
            }

            Console.ReadKey();

        }

        class Car
        {
            string make;
            string model;
            string colour;
            string rego;

            public string Make { get { return make; } set { make = value; } }
            public string Model { get { return model; } set { model = value; } }
            public string Colour { get { return colour; } set { colour = value; } }
            public string Rego { get { return rego; } set { rego = value; } }
        }

        class Person
        {
            string fname;
            string lname;
            int age;

            public string Fname { get { return fname; } set { fname = value; } }
            public string Lname { get { return lname; } set { lname = value; } }

            public Person(string _fname, string _lname, int _age)
            {
                fname = _fname;
                lname = _lname;
                age = _age;
            }

            public int getAge()
            {
                return age;
            }
        }
    }

    class Animal
    {
        
        string type;
        string name;
        int id;

        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int ID { get { return id; } set { id = value; } }

        public Animal(string _type, string _name, int _id)
        {
            type = _type;
            name = _name;
            id = _id;
        }

        public string getInfo()
        {
            return $"type: {type}   name: {name}   id: {id}";
        }
    }
}
