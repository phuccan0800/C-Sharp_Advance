using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{

    internal class Car
    {
		string Model;
		int EngineSpeed;
		int EnginePower;
		double CargoWeight;
		string CargoType;
		double Tire1Pressure;
		int Tire1Age;
        double Tire2Pressure;
        int Tire2Age;
        double Tire3Pressure;
        int Tire3Age;
        double Tire4Pressure;
        int Tire4Age;
        public Car() { }
        public Car(string model, 
            int engineSpeed, 
            int enginePower, 
            double cargoWeight,
            string cargoType,
            double tire1Pressure,
            int tire1Age,
            double tire2Pressure, int tire2Age, double tire3Pressure, 
            int tire3Age, double tire4Pressure, int tire4Age)
        {
            Model = model;
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
            CargoWeight = cargoWeight;
            CargoType = cargoType;
            Tire1Pressure = tire1Pressure;
            Tire1Age = tire1Age;
            Tire2Pressure = tire2Pressure;
            Tire2Age = tire2Age;
            Tire3Pressure = tire3Pressure;
            Tire3Age = tire3Age;
            Tire4Pressure = tire4Pressure;
            Tire4Age = tire4Age;
        }

        public string CargoTypeGet()
        {
            return this.CargoType;
        }
        public int EnginePowerGet()
        {
            return this.EnginePower;
        }
        public double Tire1PressureGet()
        {
            return this.Tire1Pressure;
        }
        public double Tire2PressureGet()
        {
            return this.Tire2Pressure;
        }
        public double Tire3PressureGet()
        {
            return this.Tire3Pressure;
        }
        public double Tire4PressureGet()
        {
            return this.Tire4Pressure;
        }
        public override string ToString()
        {
            return this.Model;
        }
    }
}
