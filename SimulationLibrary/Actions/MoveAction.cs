using SimulationLibrary.Blobs;
using SimulationLibrary.Maps;
using SimulationLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //TODO strength requirement
            //TODO energy drop?
            var b = blobs[0];
            map.Map.PlaceBlob(b, b.Tile.W + MoveDirection.X, b.Tile.H + MoveDirection.Y);
        }

        public override int CalculateAffinity(MaskedMap map, List<Blob> blobs)
        {
            return blobs[0].Affinities.Explore;
        }

        public override bool IsDoable(MaskedMap map, List<Blob> blobs)
        {
            Blob b = blobs[0];
            int w = b.Tile.W + MoveDirection.X;
            int h = b.Tile.H + MoveDirection.Y;

            return w >= 0 && w < map.Map.W && h >= 0 && h < map.Map.H;
        }
    }
}
