using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4
{
    internal class Problem6
    {
        List<Citizens> citizens = new List<Citizens>();
        List<Robots> robots = new List<Robots>();
        List<Pet> pets = new List<Pet>();
        public void Run()
        {
            string Read;
            do
            {
                Read = Console.ReadLine();
                string[] strings = Read.Split(' ');
                if (strings[0].Equals("Robot")) robots.Add(new Robots(strings[1], strings[2]));
                else if (strings[0].Equals("Citizen")) citizens.Add(new Citizens(strings[1], strings[2], strings[3], strings[4]));
                else if(strings[0].Equals("Pet")) pets.Add(new Pet(strings[1], strings[2])); 
            }
            while (Read != "End");
            string Year = Console.ReadLine();
            check(Year);
        }
        public void check(string Year)
        {
            bool check2 = false;
            foreach (Citizens citizens in citizens)
                if (citizens.CheckBirthdate(Year)) { Console.WriteLine(citizens.birthdate); check2 = true; }
            foreach (Pet pet in pets)
                if (pet.CheckBirthdate(Year)) { Console.WriteLine(pet.birthday); check2 = true; }
            if (check2 == false) Console.WriteLine("<empty output>");
        }
    }
}
