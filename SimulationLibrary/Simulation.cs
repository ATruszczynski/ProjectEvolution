using SimulationLibrary.Actions;
using SimulationLibrary.Blobs;
using SimulationLibrary.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary
{
    public class Simulation
    {
        //TODO jeden random (dice)
        //TODO cloning by constructors
        int TursLeft { get; set; }
        List<ActionA> Actions { get; set; }
        Map Map { get; set; }

        public void Start(int turnsLeft)
        {
            Map = new Map(10, 10, new List<int>() { 1, 8, 1 });
            Actions = new List<ActionA>();

            Actions.Add(new MoveAction(1,0));
            Actions.Add(new MoveAction(1,1));
            Actions.Add(new MoveAction(0,1));
            Actions.Add(new MoveAction(-1,1));
            Actions.Add(new MoveAction(-1,0));
            Actions.Add(new MoveAction(-1,-1));
            Actions.Add(new MoveAction(0,-1));
            Actions.Add(new MoveAction(1,-1));
            Actions.Add(new EatAction());
            Actions.Add(new Procreate1Action());

            Blob b = new Blob(Actions);
            Map.PlaceBlob(b, 5, 5);

            TursLeft = turnsLeft;
            for (; TursLeft > 0; TursLeft--)
            {
                Map.PlaceFood(10);
                foreach (var blob in Map.Blobs)
                {
                    blob.MakeMove();
                }
            }
        }
    }
}
