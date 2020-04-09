using SimulationLibrary.Actions;
using SimulationLibrary.Features;
using SimulationLibrary.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Blobs
{
    class Blob
    {
        public MaskedMap Map { get; set; }
        public Tile Tile { get; set; }
        public Genome Genome { get; set; }
        public List<ActionA> History { get; set; }
        public List<ActionA> PossibleMoves { get; set; }
        public Blob(Map map, Tile tile, List<ActionA> actions)
        {
            Map = new MaskedMap(map);
            Tile = tile;
            PossibleMoves = actions;
            History = new List<ActionA>();
        }
        public void MakeMove()
        {
            Console.WriteLine("Move");
        }
    }
}
