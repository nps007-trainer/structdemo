using System;


namespace structdemo
{
    public struct Person
    {
        public string Name;
        public int Age;
        public int Weight;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning Structures!");
            // Declare obj of person type

            Person p1;
            p1.Name = "Swapnil";
            p1.Age = 24;
            p1.Weight = 60;

            Console.WriteLine("The Person details are ");
            Console.WriteLine("Name {0} , AGe {1} , Weight {2}", p1.Name, p1.Age, p1.Weight);

            //Copy the details of a person into another object
            Person p2 = p1;
            p2.Name = "Jitendra";
            Console.WriteLine("The Person details are ");
            Console.WriteLine("Name {0} , AGe {1} , Weight {2}", p2.Name, p2.Age, p2.Weight);

        }
    }
}
