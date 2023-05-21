using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4
{
    internal class Problem5
    {
        List<Citizens> citizens = new List<Citizens>();
        List<Robots> robots = new List<Robots>();
        public void Run()
        {
            string Read;
            do
            {
                Read = Console.ReadLine();
                string[] strings = Read.Split(' ');
                if (strings.Length == 2) robots.Add(new Robots(strings[0], strings[1]));
                else if (strings.Length == 3) citizens.Add(new Citizens(strings[0], strings[1], strings[2]));
            }
            while (Read != "End");
            string FakeId = Console.ReadLine();
            check(FakeId);
        }
        public void check(string FakeId)
        {
            foreach (Citizens citizens in citizens)
                if (citizens.TheLastDigitsOfFakeIDs(FakeId)) Console.WriteLine(citizens.Id);
            foreach (Robots robot in robots)
                if (robot.TheLastDigitsOfFakeIDs(FakeId)) Console.WriteLine(robot.Id);
        }
    }
    interface ID
    {
        string Id { get; }
        bool TheLastDigitsOfFakeIDs(string Id);
        bool CheckBirthdate(string Birthdate);
    }
    class Citizens : ID
    {
        public string name;
        public string age;
        public string Id { get; }
        public string birthdate;
        public bool TheLastDigitsOfFakeIDs(string IdFake)
        {
            bool check = false;
            string lastThreeCharsOfString1 = Id.Substring(Id.Length - 3);
            if (lastThreeCharsOfString1 == IdFake) check = true;
            return check;
        }
        public bool CheckBirthdate(string Birthdate)
        {
            bool check = false;
            string lastFourChars = birthdate.Substring(birthdate.Length - 4);
            if (lastFourChars == Birthdate) check = true;
            return check;
        }

        public Citizens(string name, string age, string id)
        {
            this.name = name;
            this.age = age;
            Id = id;
        }
        public Citizens(string name, string age, string id, string birthdate) : this(name, age, id)
        {
            this.birthdate = birthdate;
        }
    }
    class Pet 
    {
        public string name { get; set; }
        public string birthday { get; set; }

        public Pet(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
        public bool CheckBirthdate(string Birthdate)
        {
            bool check = false;
            string lastFourChars = birthday.Substring(birthday.Length - 4);
            if (lastFourChars == Birthdate) check = true;
            return check;
        }
    }
    class Robots : ID
    {
        public string model;
        public string Id { get; }
        public bool TheLastDigitsOfFakeIDs(string IdFake)
        {
            bool check = false;
            string lastThreeCharsOfString1 = Id.Substring(Id.Length - 3);
            if (lastThreeCharsOfString1 == IdFake) check = true;
            return check;
        }
        public Robots(string model, string id)
        {
            this.model = model;
            Id = id;
        }
        public bool CheckBirthdate(string Birthdate)
        {
            return false;
        }
    }

}
