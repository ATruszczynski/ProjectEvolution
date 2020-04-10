using SimulationLibrary.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Utility
{
    class Procreator
    {
        public static Blob Procreate1(Blob parent)
        {
            Blob child = parent.Clone();

            //TODO modify strenght

            return child;
        }
    }
}
