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
                    Problem3();
                    break;
                case 4:
                    Problem4();
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
                Car[i] = new Car().Add(temp);
            }
            string check = Console.ReadLine();
            for (int i = 0; i < n; i++) Car[i].checkCar(check);
        }
        static void Problem2()
        {
            Console.WriteLine("Input Number Of Engine: ");
            int m = int.Parse(Console.ReadLine());
            Engine[] Engines = new Engine[m];
            for (int i = 0; i < m; i++)
            {
                string temp = Console.ReadLine();
                Engines[i] = new Engine().Add(temp);
            }
            
            Console.WriteLine("Input Number Of Car: ");
            int n = int.Parse(Console.ReadLine());
            Car2[] Car = new Car2[n];
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                Car[i] = new Car2().Add(temp);
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
        static void Problem3()
        {
            string temp = Console.ReadLine();
            string[] ArrTemp = new string[2];
            ArrTemp = temp.Split(' ');
            int min = int.Parse(ArrTemp[0]);
            int max = int.Parse(ArrTemp[1]);
            temp = Console.ReadLine();
            ArrTemp = temp.Split(' ');
            int xOfIvo = int.Parse(ArrTemp[0]);
            int yOfIvo = int.Parse(ArrTemp[1]);
            temp = Console.ReadLine();
            ArrTemp = temp.Split(' ');
            int xOfEvill = int.Parse(ArrTemp[0]);
            int yOfEvill = int.Parse(ArrTemp[1]);
            Console.WriteLine("");
            int sum = 0;
            xOfIvo--;
            yOfIvo++;
            xOfEvill--;
            yOfEvill--;
            do
            {
                if (yOfIvo != yOfEvill) sum = sum + (max * xOfIvo + yOfIvo);
                xOfIvo--;
                yOfIvo++;
                xOfEvill--;
                yOfEvill--;

            }
            while ( xOfIvo >= 0 );
            Console.WriteLine(sum);
        }
        static void Problem4()
        {
            Patients[] patients = new Patients[100];
            string temp = Console.ReadLine();
            int i = 0;
            do
            {
                string[] ArrTemp = new string[4];
                ArrTemp = temp.Split(' ');
                if (ArrTemp.Length == 4) patients[i] = new(ArrTemp[0], $"{ArrTemp[1]} {ArrTemp[2]}", ArrTemp[3]);
            }
            while (temp != "Output") ;
        }
    }
}
