using System;

namespace Exercitiul2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------List of Cars--------------------");
            var vehicleDirector = new VehicleDirector(new SedanBuilder());
            vehicleDirector.CreateVehicle();
            var vehicle = vehicleDirector.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");

            vehicleDirector = new VehicleDirector(new SuvBuilder());
            vehicleDirector.CreateVehicle();
            vehicle = vehicleDirector.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");

            vehicleDirector = new VehicleDirector(new HatchbackBuilder());
            vehicleDirector.CreateVehicle();
            vehicle = vehicleDirector.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");

            vehicleDirector = new VehicleDirector(new CrossoverBuilder());
            vehicleDirector.CreateVehicle();
            vehicle = vehicleDirector.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");

            vehicleDirector = new VehicleDirector(new PickupBuilder());
            vehicleDirector.CreateVehicle();
            vehicle = vehicleDirector.GetVehicle();
            vehicle.ShowInfo();

            Console.ReadKey();
        }
    }
}
