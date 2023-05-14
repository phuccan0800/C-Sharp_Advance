using System;

namespace DAY2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chosse Problem you want (1-7): ");
            int chosse = int.Parse(Console.ReadLine());
            switch (chosse) {
                case 1:
                    Problem1();
                    break;
                case 2:
                    Problem2();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
        }
        static void Problem1()
        {
            int n = int.Parse(Console.ReadLine());
            Car[] Car = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                string[] temp2 = new string[100];
                temp2 = temp.Split(' ');
                Car[i] = new Car(
                    temp2[0],
                    int.Parse(temp2[1]),
                    int.Parse(temp2[2]),
                    double.Parse(temp2[3]),
                    temp2[4],
                    double.Parse(temp2[5]),
                    int.Parse(temp2[6]),
                    double.Parse(temp2[7]),
                    int.Parse(temp2[8]),
                    double.Parse(temp2[9]),
                    int.Parse(temp2[10]),
                    double.Parse(temp2[11]),
                    int.Parse(temp2[12]));
            }
            string check = Console.ReadLine();
            for (int i = 0; i < n; i++) Car[i].checkCar(check);
        }
        static void Problem2()
        {
            int m = int.Parse(Console.ReadLine());
            Engine[] Engines = new Engine[m];
            for (int i = 0; i < m; i++)
            {
                string temp = Console.ReadLine();
                string[] temp2 = new string[4];
                for (int j = 0; j < 4; j++) temp2[j] = null;
                temp2 = temp.Split(' ');
                if (temp2[2] != null)
                {
                    int number;
                    bool isTrue = int.TryParse(temp2[2], out number);
                    try
                    {
                        if (isTrue && temp2[3] == null) Engines[i] = new Engine(temp2[0], int.Parse(temp2[1]), int.Parse(temp2[2]));
                        else if (isTrue && temp2[3] != null) Engines[i] = new Engine(temp2[0], int.Parse(temp2[1]), int.Parse(temp2[2]), temp2[3]);
                        else if (isTrue == false && temp2[3] != null) Engines[i] = new Engine(temp2[0], int.Parse(temp2[1]), temp2[2]);
                    } catch (IndexOutOfRangeException e) 
                    {
                        Engines[i] = new Engine(temp2[0], int.Parse(temp2[1]), int.Parse(temp2[2]));
                    }
                   
                }
                else if (temp2[2] == null) Engines[i] = new Engine(temp2[0], int.Parse(temp2[1]));
                Console.WriteLine($"{i} {m} ");
                Console.WriteLine(Engines[i].ToString());
            }
            Console.WriteLine(" Input Number Of Car: ");
            int n = int.Parse(Console.ReadLine());
            Car2[] Car = new Car2[n];
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                string[] temp2 = new string[100];
                for (int j = 0; j<4; j++) temp2[j] = null;
                temp2 = temp.Split(' ');
                if (temp2.Length >2)
                {
                    int number;
                    bool isTrue = int.TryParse(temp2[2], out number);
                    if (isTrue && temp2[3] == null) Car[i] = new Car2(temp2[0], temp2[1], int.Parse(temp2[2]));
                    else if (isTrue && temp2[3] != null) Car[i] = new Car2(temp2[0], temp2[1], int.Parse(temp2[2]), temp2[3]);
                    else if (isTrue == false && temp2[3]!=null) Car[i] =  new Car2(temp2[0], temp2[1], temp2[2]);
                }
                else if (temp2.Length = 2) Car[i] = new Car2(temp2[0], temp2[1]);
            }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (Engines[j].ModelGet() == Car[i].GetEngine())
                    {
                        Console.WriteLine(Car[i].ToString(Engines[j]));
                        break;
                    }
                }
        }
    }
}
