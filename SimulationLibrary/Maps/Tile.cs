using SimulationLibrary.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Maps
{
    class Tile
    {
        TileType TileType { get; set; }
        public List<Blob> Blobs { get; set; }
        public int W {get; set;}
        public int H {get; set;}
        public Tile(int w, int h, TileType tileType = TileType.Unknown)
        {
            Blobs = new List<Blob>();
            W = w;
            H = h;
            TileType = tileType;
        }
    }
}
