﻿using SimulationLibrary.Blobs;
using SimulationLibrary.Maps;
using SimulationLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimulationLibrary.Actions.MoveDirection;

namespace SimulationLibrary.Actions
{
    class MoveAction : ActionA
    {
        Vector2D MoveDirection { get; set; }

        public MoveAction(int w, int h):this(new Vector2D(w, h)) { }
        public MoveAction(Vector2D moveDireciton)
        {
            MoveDirection = moveDireciton;
        }
        public override void Attempt(MaskedMap map, List<Blob> blobs)
        {
            var b = blobs[0];
            map.Map.PlaceBlob(b, b.Tile.W + MoveDirection.X, b.Tile.H + MoveDirection.Y);
            Console.WriteLine("Blob moved");
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
