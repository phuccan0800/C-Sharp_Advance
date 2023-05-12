using System;

namespace DAY2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());
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
            for (int i = 0; i < n; i++)
            {
                if (check.Equals(Car[i].CargoTypeGet()))
                {
                    switch (check)
                    {
                        case "fragile":
                            double x = Car[i].Tire1PressureGet;
                            if (x > 1.0) Console.WriteLine(Car[i].ToString());
                            break;
                        case "flamable":
                            if (Car[i].EnginePowerGet() > 250) Console.WriteLine(Car[i].ToString());
                            break;
                    }

                }
            }
        }
    }
}
