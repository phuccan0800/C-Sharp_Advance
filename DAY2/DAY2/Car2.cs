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
            return $"{this.Model}: \n  " +
                       $"{engine.ModelGet()}: \n    "+
                       $"Displacement: {engine.PowerGet()}\n    "+
                       $"Efficiency: {engine.EfficiencyGet()}\n  "+
                       $"Weight: {this.Weight}\n  "+
                       $"Color: {this.Color}";
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
        public string EfficiencyGet() { return Efficiency; }

        public override string ToString()
        {
            return $"{this.Model} {this.Power} {this.Displacament} {this.Efficiency} ";
        }
    }

}
