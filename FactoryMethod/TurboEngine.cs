using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TurboEngine:AbstractEngine
    {
        public TurboEngine(int size) :base(size, true) {

        }
    }
}
