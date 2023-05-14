using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    internal class Car2
    {
        private string Model;
        private string Engine;
        private int Weight;
        private string Color; 
        public Car2() { }

        public Car2(string model, string engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public Car2(string model, string engine)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = "n/a";
        }
        public Car2(string model, string engine, int weight) 
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = "n/a";
        }
        public Car2(string model, string engine, string color) 
        {
            Model = model;
            Engine = engine;
            Color = color;
            Weight = 0;
        }
        public string GetEngine() { return Engine; }

        public string ToString(Engine engine)
        {
            string OutPut;
            if (this.Weight >0 ) OutPut = $"{this.Model}: \n  " +
                       $"{engine.ModelGet()}: \n    " +
                       $"Power: {engine.PowerGet()}\n    " +
                       $"Displacement: {engine.DisplacamentGet()}\n    " +
                       $"Efficiency: {engine.EfficiencyGet()}\n  " +
                       $"Weight: {this.Weight}\n  " +
                       $"Color: {this.Color}";
            else OutPut = $"{this.Model}: \n  " +
                       $"{engine.ModelGet()}: \n    " +
                       $"Power: {engine.PowerGet()}\n    " +
                       $"Displacement: {engine.DisplacamentGet()}\n    " +
                       $"Efficiency: {engine.EfficiencyGet()}\n  " +
                       $"Weight: n/a\n  " +
                       $"Color: {this.Color}";
            return OutPut;
        }
        public Car2 Add(string temp)
        {
            Car2 car = new Car2();
            string[] temp2 = new string[100];
            for (int j = 0; j < 4; j++) temp2[j] = null;
            temp2 = temp.Split(' ');
            if (temp2.Length > 2)
            {
                int number;
                bool isTrue = int.TryParse(temp2[2], out number);
                if (isTrue && temp2.Length == 3) car = new Car2(temp2[0], temp2[1], int.Parse(temp2[2]));
                else if (isTrue && temp2.Length > 3) car = new Car2(temp2[0], temp2[1], int.Parse(temp2[2]), temp2[3]);
                else if (isTrue == false && temp2.Length == 3) car = new Car2(temp2[0], temp2[1], temp2[2]);
            }
            else if (temp2.Length == 2) car = new Car2(temp2[0], temp2[1]);
            return car;
        }
    }
    internal class Engine
    {
        private string Model;
        private int Power;
        private int Displacament;
        private string Efficiency;
        public Engine() { }
        public Engine(string model, int power, string efficiency)
        {
            Model = model;
            Power = power;
            Displacament = 0;
            Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacament)
        {
            Model = model;
            Power = power;
            Efficiency = "n/a";
            Displacament = displacament;
        }

        public Engine(string model, int power, int displacament, string efficiency)
        {
            Model = model;
            Power = power;
            Displacament = displacament;
            Efficiency = efficiency;
        }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }
        public string ModelGet() { return Model; }
        public int PowerGet() { return Power; }
        public int DisplacamentGet() { return Displacament; }
        public string EfficiencyGet() { return Efficiency; }

        public override string ToString()
        {
            return $"{this.Model} {this.Power} {this.Displacament} {this.Efficiency} ";
        }
        public Engine Add(string temp)
        {
            Engine engine = new Engine();
            string[] temp2 = new string[4];
            for (int j = 0; j < 4; j++) temp2[j] = null;
            temp2 = temp.Split(' ');
            if (temp2.Length > 2)
            {
                int number;
                bool isTrue = int.TryParse(temp2[2], out number);
                if (isTrue && temp2.Length == 3) engine = new Engine(temp2[0], int.Parse(temp2[1]), int.Parse(temp2[2]));
                else if (isTrue && temp2.Length > 3) engine = new Engine(temp2[0], int.Parse(temp2[1]), int.Parse(temp2[2]), temp2[3]);
                else if (isTrue == false && temp2.Length == 3) engine = new Engine(temp2[0], int.Parse(temp2[1]), temp2[2]);
            }
            else if (temp2.Length == 2) engine = new Engine(temp2[0], int.Parse(temp2[1]));
            return engine;
        }
    }

}
