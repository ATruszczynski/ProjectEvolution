using SimulationLibrary.Blobs;
using SimulationLibrary.Placeables;
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
        public int W { get { return Tiles.GetLength(0); } }
        public int H { get { return Tiles.GetLength(1); } }
        public List<Blob> Blobs { get; set; }
        public Map(int w, int h)
        {
            Blobs = new List<Blob>();
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
            Blobs.Add(blob);
            Tiles[w, h].Blobs.Add(blob);
            blob.Tile = Tiles[w, h];
            blob.Map.Reveal(w, h);
        }

        public void RemoveBlob(Blob blob)
        {
            blob.Tile.Blobs.Remove(blob);
            Blobs.Remove(blob);
        }

        public Tile this[int w, int h]
        {
            get
            {
                return Tiles[w, h];
            }
        }

        public void PlaceFood(int howMany)
        {
            Random random = new Random();
            for (int i = 0; i < howMany; i++)
            {
                var w = random.Next(W);
                var h = random.Next(H);

                Tiles[w, h].Placeables.Add(new Food());
            }
        }
    }
}
