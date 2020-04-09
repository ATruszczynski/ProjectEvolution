using SimulationLibrary.Blobs;
using SimulationLibrary.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Actions
{
    class MoveAction : ActionA
    {
        MoveDirection MoveDirection { get; set; }

        public MoveAction(MoveDirection moveDirection)
        {
            MoveDirection = moveDirection;
        }
        public override void Attempt(Map map, List<Blob> blobs)
        {
            throw new NotImplementedException();
        }

        public override int CalculateAffinity(Map map, List<Blob> blobs)
        {
            throw new NotImplementedException();
        }

        public override bool IsDoable(Map map, List<Blob> blobs)
        {
            throw new NotImplementedException();
        }
    }
}
