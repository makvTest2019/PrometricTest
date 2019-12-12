using MV.Prometric.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = CreateVehicleList();

            Console.WriteLine(String.Concat(Enumerable.Repeat("=", 150)));
            Console.WriteLine("Make        Max Speed         Model         NoOfWheels      Passengers         Fuel Efficiency(km/litre)     Efficiency Per passenger    BicycleName");
            Console.WriteLine(String.Concat(Enumerable.Repeat("=", 150)));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Details());
            }

            ShowMostEfficientVehicle(vehicles);

            Console.WriteLine("Press any ket to exit.");
            Console.ReadLine();
        }

        private static void ShowMostEfficientVehicle(List<Vehicle> vehicles)
        {
            Console.WriteLine(String.Concat(Enumerable.Repeat("=", 150)));
            var mostEfficientVehicle = vehicles.Where(o => o.VehicleType == 3 || o.VehicleType == 4).Aggregate((i1, i2) => i1.FuelEfficientPerPassenger > i2.FuelEfficientPerPassenger ? i1 : i2);

            Console.WriteLine("The most efficient vehicle is :");

            Console.WriteLine(mostEfficientVehicle.VehicleType == 3 ? "Bus" : "Boat " + ", Model - " + mostEfficientVehicle.Model + ", Efficiency Per passenger - " + mostEfficientVehicle.FuelEfficientPerPassenger);
        }

        private static List<Vehicle> CreateVehicleList()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car { VehicleType = 1, Make = "Tes", Max = 100, Model = "M3", Noofwheels = 4, Passengers = 5, FuelEfficiency = 50 });
            vehicles.Add(new Bicycle { VehicleType = 2, Make = "DFR", Max = 20, Model = "R3", Noofwheels = 2, Passengers = 1 });
            vehicles.Add(new Bus { VehicleType = 3, Make = "TCM", Max = 70, Model = "N1", Noofwheels = 4, Passengers = 40, FuelEfficiency = 30 });
            vehicles.Add(new Boat { VehicleType = 4, Make = "BHT", Max = 80, Model = "S1", Noofwheels = 0, Passengers = 5, FuelEfficiency = 25 });
            return vehicles;
        }
    }
}
