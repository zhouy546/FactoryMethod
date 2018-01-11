using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class CarBuilder:VehicleBuilder
    {
        private AbstractCar carInProgress;

        public CarBuilder(AbstractCar car) {
            carInProgress = car;
        }

        public override void BuildBody()
        {
            Console.WriteLine("building car body");
        }

        public override void BuildBoot()
        {
            Console.WriteLine("build car boot");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("build car Chassis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("building car passenger area");
        }

        public override void BuildWindow()
        {
            Console.WriteLine("building car window");
        }

        public override IVehicle Vehicle {
            get {
                return carInProgress;
            }
        }
    }
}
