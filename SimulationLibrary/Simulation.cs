using SimulationLibrary.Actions;
using SimulationLibrary.Blobs;
using SimulationLibrary.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimulationLibrary.Actions.MoveDirection;

namespace SimulationLibrary
{
    public class Simulation
    {
        int TursLeft { get; set; }
        List<Blob> Blobs { get; set; }
        List<ActionA> Actions { get; set; }
        Map Map { get; set; }

        public void Start(int turnsLeft)
        {
            Map = new Map(10, 10, new List<int>() { 1, 8, 1 });
            Actions = new List<ActionA>();

            Actions.Add(new MoveAction(N));
            Actions.Add(new MoveAction(NW));
            Actions.Add(new MoveAction(W));
            Actions.Add(new MoveAction(SW));
            Actions.Add(new MoveAction(S));
            Actions.Add(new MoveAction(SE));
            Actions.Add(new MoveAction(E));
            Actions.Add(new MoveAction(NE));

            Blobs = new List<Blob>();
            Blobs.Add(new Blob(Map, Map[0,0], Actions));
            Blobs.Add(new Blob(Map, Map[9,9],Actions));
            TursLeft = turnsLeft;
            for (; TursLeft > 0; TursLeft--)
            {
                foreach (var blob in Blobs)
                {
                    blob.MakeMove();
                }
            }
        }
    }
}
