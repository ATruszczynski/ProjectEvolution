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
        //TODO energy
        public MaskedMap Map { get; set; }
        public Tile Tile { get; set; }
        public Genome Genome { get; set; }
        public Affinities Affinities { get; set; }
        public List<ActionA> History { get; set; }
        public List<ActionA> PossibleMoves { get; set; }
        public Blob(List<ActionA> actions)
        {
            Affinities = new Affinities();
            PossibleMoves = actions;
            History = new List<ActionA>();
        }
        public void MakeMove()
        {
            Random r = new Random();
            var choice = r.Next(8);
            PossibleMoves[choice].Attempt(Map, new List<Blob>() { this });
        }

        public Blob Clone()
        {
            Blob child = new Blob(PossibleMoves);

            child.Genome = new Genome(Genome);

            return child;
        }
    }
}
