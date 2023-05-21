using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4
{ 
    internal class Problem7
    {
        List<Rebels> rebels = new List<Rebels>();
        List<Citizens7> citizens = new List<Citizens7>();
        public void Run()
        {
            int Total = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string ReadInput = Console.ReadLine();
                string[] strings = ReadInput.Split(' ');
                i = checkName(strings, i); 
            }
            string Read;
            do
            {
                Read = Console.ReadLine(); 
                for (int i = 0; i < citizens.Count; i++)
                    if (citizens[i].Name.Equals(Read)) Total = citizens[i].BuyFood(Total);
                for (int i = 0; i < rebels.Count; i++)
                    if (rebels[i].Name.Equals(Read)) Total = rebels[i].BuyFood(Total);
            }
            while (Read != "End");
            Console.WriteLine(Total);
        }
        public int checkName(string[] strings, int i)
        {
            bool Duplicated = false;
            for (int j = 0; j < citizens.Count; j++)
                if (strings[0].Equals(citizens[j].Name))
                {
                    Console.WriteLine("THIS NAME DUPLICATE BEFORE !!! PLEASE TYPE ANOTHER NAME");
                    Duplicated = true;
                    i--;
                    break;
                }
            if (!Duplicated)
            {
                for (int j = 0; j < rebels.Count; j++)
                    if (strings[0].Equals(rebels[j].Name))
                    {
                        Console.WriteLine("THIS NAME DUPLICATE BEFORE !!! PLEASE TYPE ANOTHER NAME");
                        Duplicated = true;
                        i--;
                        break;
                    }
            }
            if (!Duplicated)
            {
                if (strings.Length == 4) citizens.Add(new Citizens7(strings[0], strings[1], strings[2], strings[3]));
                else if (strings.Length == 3) rebels.Add(new Rebels(strings[0], strings[1], strings[2]));
            }
            return i;
        }
    }
    interface IBuyer
    {
        int BuyFood(int Food);
    }

    public class Rebels : IBuyer
    {
        public string Name;
        public string Age;
        public string Group;
        public int BuyFood(int Food)
        {
            return Food+5;
        }
        public Rebels(string name, string age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
    }
    public class Citizens7 : IBuyer
    {
        public string Name;
        public string Age;
        public string Id;
        public string Birthdate;
        public int BuyFood(int Food)
        {
            return Food + 10;
        }

        public Citizens7(string name, string age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
    }
}
