using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Car : Vehicle
    {
        public string Model;
        public string Brand;
        public double ShowInfo;
        public double FuelCapacity;
        public double FuelFor1km;
        public double CurrentFuel;
        public double Drive;


        public Car(string model, string brand, double currentfuel, double drive, double fuelfor1km, double fuelcapacity, int year) 

        {
            if (currentfuel / drive >= fuelfor1km)
            {
                 ShowInfo = currentfuel - drive * fuelfor1km;
                Console.WriteLine(ShowInfo);
            }
            else
            {
                Console.WriteLine("ceninizde kifayet qeder benzin yoxdur");
            }
            this.Model = model;
            this.Brand = brand;
            this.CurrentFuel = currentfuel;
            this.Drive = drive;
            this.FuelFor1km = fuelfor1km;
            this.FuelCapacity = fuelcapacity;
            this.Year = year;
            
        }
    }
}
