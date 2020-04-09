using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Rolls
{
    class ThresholdDice
    {
        public int DiceMax { get; }
        public List<int> Thresholds { get; }
        public Random Random { get; }
        public ThresholdDice(List<int> thresholds)
        {
            DiceMax = thresholds[thresholds.Count-1];
            Thresholds = thresholds;
            Random = new Random();
        }

        public int Roll()
        {
            int score = Random.Next(1, DiceMax + 1);
            int t = 0;
            for (; t < Thresholds.Count; t++)
            {
                if (score <= Thresholds[t])
                    break;
            }
            return t;
        }
    }
}
