using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4
{
    internal class Problem3
    {
        Ferrari batGiorgi = new BatGiorgi();
        Ferrari dinko = new Dinko();
        public void Run()
        {
            string name = Console.ReadLine();
            checkAndPrint(name);
        }
        public void checkAndPrint (string name)
        {
            switch (name)
            {
                case "Bat Giorgi":
                    Console.WriteLine(batGiorgi.ToString());
                    break;
                case "Dinko":
                    Console.WriteLine(dinko.ToString());
                    break;
            }
        }
         public interface Ferrari
        {
            string model { get; set; } 
            string brakes { get; set; } 
            string gasPedal { get; set; } 
            public string driverName { get; set; }

        }
        public class BatGiorgi : Ferrari
        {
            public string model { get; set; } = "488-Spider";
            public string brakes { get; set; } = "Brakes!";
            public string gasPedal { get; set; } = "Zadu6avam sA!";
            public string driverName { get; set; } = "Bat Giorgi";
            public override string ToString()
            {
                return $"{model}/{brakes}/{gasPedal}/{driverName}";
            }
        }
        public class Dinko : Ferrari
        {
            public string model { get; set; } = "488-Spider";
            public string brakes { get; set; } = "Brakes!";
            public string gasPedal { get; set; } = "Zadu6avam sA!";
            public string driverName { get; set; } = "Dinko";

            public override string ToString()
            {
                return $"{model}/{brakes}/{gasPedal}/{driverName}";
            }
        }
    }
}
