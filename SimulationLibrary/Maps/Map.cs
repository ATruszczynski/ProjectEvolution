using SimulationLibrary.Blobs;
using SimulationLibrary.Rolls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimulationLibrary.Maps.TileType;

namespace SimulationLibrary.Maps
{
    class Map
    {
        public Tile[,] Tiles { get; set; }
        public Map(int w, int h)
        {
            Tiles = new Tile[w, h];
            for (int wi = 0; wi < w; wi++)
            {
                for (int hi = 0; hi < h; hi++)
                {
                    Tiles[w, h] = new Tile(w,h);
                }
            }
        }
        public Map(int w, int h, List<int> proportions)
        {
            ThresholdDice d = new ThresholdDice(proportions);
            Tiles = new Tile[w, h];
            for (int wi = 0; wi < w; wi++)
            {
                for (int hi = 0; hi < h; hi++)
                {
                    TileType t = Normal;
                    switch(d.Roll())
                    {
                        case 0:
                            t = Shelter;
                            break;
                        case 2:
                            t = Obstacle;
                            break;
                    }
                    Tiles[wi, hi] = new Tile(wi,hi,t);
                }
            }
        }

        public void PlaceBlob(Blob blob, int w, int h)
        {
            if(blob.Map == null)
            {
                blob.Map = new MaskedMap(this);
            }
            if(blob.Tile != null)
            {
                blob.Tile.Blobs.Remove(blob);
            }
            Tiles[w, h].Blobs.Add(blob);
            blob.Tile = Tiles[w, h];
        }

        public Tile this[int w, int h]
        {
            get
            {
                return Tiles[w, h];
            }
        }
    }
}
