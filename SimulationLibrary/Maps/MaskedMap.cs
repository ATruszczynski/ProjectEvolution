using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Maps
{
    class MaskedMap
    {
        public Map Map { get; set; }
        public bool[,] Visibility { get; set; }
        public MaskedMap(Map map)
        {
            Map = map;
            Visibility = new bool[Map.Tiles.GetLength(0), Map.Tiles.GetLength(1)];
        }

        public void Reveal(int w, int h)
        {
            var mw = Map.Tiles.GetLength(0);
            var mh = Map.Tiles.GetLength(1);
            for (int wi = w - 1; wi <= w + 1; wi++)
            {
                for (int hi = h - 1; hi <= h + 1; hi++)
                {
                    if (wi >= 0 && wi < mw && hi >= 0 && hi < mh)
                    {
                        Visibility[wi, hi] = true;
                    }
                }
            }
        }
    }
}
