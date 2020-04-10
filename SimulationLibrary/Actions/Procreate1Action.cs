using SimulationLibrary.Blobs;
using SimulationLibrary.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Actions
{
    class Procreate1Action : ActionA
    {
        public override void Attempt(MaskedMap map, List<Blob> blobs)
        {
            var blob = blobs[0];
            map.Map.RemoveBlob(blob);

            Random random = new Random();
            random.Next(2);

            
        }

        public override int CalculateAffinity(MaskedMap map, List<Blob> blobs)
        {
            throw new NotImplementedException();
        }

        public override bool IsDoable(MaskedMap map, List<Blob> blobs)
        {
            throw new NotImplementedException();
        }
    }
}
