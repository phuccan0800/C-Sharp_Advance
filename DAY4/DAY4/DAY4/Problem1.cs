using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4
{
    internal class Problem1
    {
        public void Run()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Iperson person = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

        }
    }
    public interface IBirthable
    {
        string Birthdate { get; set; }
    }

    public interface IIdentifiable : IBirthable
    {
        string Id { get; set; }
    }
    public interface Iperson
    {
        string Name { get; }
        int Age { get; }
    }
    public class Citizen : Iperson , IBirthable , IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public string Id { get; set; }

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Citizen(string name, int age, string birthdate, string id) : this(name, age)
        {
            Birthdate = birthdate;
            Id = id;
        }
    }
}