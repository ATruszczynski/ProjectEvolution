using SimulationLibrary.Blobs;
using SimulationLibrary.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Actions
{
    abstract class ActionA
    {
        abstract public bool IsDoable(Map map, List<Blob> blobs);
        abstract public void Attempt(Map map, List<Blob> blobs);
        abstract public int CalculateAffinity(Map map, List<Blob> blobs);
    }
}
