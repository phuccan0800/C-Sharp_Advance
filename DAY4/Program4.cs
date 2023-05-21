using System;

namespace DAY1
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

        }
    }
    interface class Iperson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Iperson() { }
        public override ToString()
        {
           
        }
        
    }
    internal class Citizen:Iperson
    {

        public override ToString()
        {
            return Name + "\n" + Age;
        }
    }
}