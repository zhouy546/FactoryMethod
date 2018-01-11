using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class VanBuilder:VehicleBuilder
    {
        private AbstractVan vanInProgress;
        public VanBuilder(AbstractVan van) {
            vanInProgress = van;
        }
        public override void BuildBody()
        {
            Console.WriteLine("building van body");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building van Chsaais");
        }

        public override void BuildReinforceStorageArea()
        {
            Console.WriteLine("building van Reinforce Storage Area");
        }

        public override void BuildWindow()
        {
            Console.WriteLine("building van Window");
        }

        public override IVehicle Vehicle {
            get {
                return vanInProgress;
            }
        }
    }
}
