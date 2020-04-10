using SimulationLibrary.Blobs;
using SimulationLibrary.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Actions
{
    class EatAction : ActionA
    {
        public override void Attempt(MaskedMap map, List<Blob> blobs)
        {
            var blob = blobs[0];
            int w = blob.Tile.W;
            int h = blob.Tile.H;

            map.Map[w, h].Placeables.RemoveAt(map.Map[w, h].Placeables.Count - 1);
            blob.Affinities.Procreate = 100;
            blob.Affinities.Eating = 0;
            blob.Affinities.Explore = 0;
        }

        public override int CalculateAffinity(MaskedMap map, List<Blob> blobs)
        {
            return blobs[0].Affinities.Eating;
        }

        public override bool IsDoable(MaskedMap map, List<Blob> blobs)
        {
            var blob = blobs[0];
            int w = blob.Tile.W;
            int h = blob.Tile.H;

            return map.Map[w, h].Placeables.Count != 0; //TODO Not universal
        }
    }
}
