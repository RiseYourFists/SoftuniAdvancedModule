using System;

namespace CarManufacturer
{

    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsuption)
            :this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsuption;

        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsuption, Engine engine, Tire[] tires)
            :this(make, model, year, fuelQuantity, fuelConsuption)
        {
            Engine = engine;
            Tires = tires;
        }

        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Tire[] Tires { get { return tires; } set { tires = value; } }

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public void Drive(double distance)
        {
            var burnedFuel = (fuelConsumption * distance)/100;

            if (!(fuelQuantity - burnedFuel > 0))
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }

            fuelQuantity -= burnedFuel;
        }

        public string WhoAmI()
        {
            var info = $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F1}";
            return info;
        }

        public double GetPressure()
        {
            var pressure = 0.0;
            foreach (var tire in this.Tires)
            {
                pressure += tire.Pressure;
            }
            return pressure;
        }
    }
}
