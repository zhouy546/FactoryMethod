using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.Build(VehicleFactory.DrivingStyle.Economical, VehicleColour.Blue);
            Console.WriteLine(car);

            VehicleFactory vanFactory = new VanFactory();
            IVehicle van = vanFactory.Build(VehicleFactory.DrivingStyle.Powerful, VehicleColour.White);
            Console.WriteLine(van);

            IVehicle sporty = VehicleFactory.Make(VehicleFactory.Category.Car, VehicleFactory.DrivingStyle.Powerful, VehicleColour.Red);
            Console.WriteLine(sporty);

            Console.Read();
        }
    }
}
