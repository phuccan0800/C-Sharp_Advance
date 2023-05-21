using System;

namespace DAY4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem1 problem1 = new Problem1();
            Problem2 problem2 = new Problem2();
            Problem3 problem3 = new Problem3();
            Problem4 problem4 = new Problem4();
            Problem5 problem5 = new Problem5();
            Problem6 problem6 = new Problem6();
            Problem7 problem7 = new Problem7();
            Problem9 problem9 = new Problem9();
            Console.Write("Choose one Problem: ");
            string read = Console.ReadLine();
            switch (read)
            {
                case "1":
                    problem1.Run();
                    break;
                case "2":
                    problem2.Run();
                    break;
                case "3":
                    problem3.Run();
                    break;
                case "4":
                    problem4.Run();
                    break ;
                case "5":
                    problem5.Run();
                    break;
                case "6":
                    problem6.Run();
                    break;
                case "7":
                    problem7.Run();
                    break;
                case "9":
                    problem9.Run();
                    break;
            }

        }
    }
}
