using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLibrary.Features
{
    class Genome
    {
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public Genome()
        {

        }

        public Genome(Genome genome)
        {
            Strength = genome.Strength;
            Constitution = genome.Constitution;
            Dexterity = genome.Dexterity;
            Intelligence = genome.Intelligence;
            Wisdom = genome.Wisdom;
            Charisma = genome.Charisma;
        }
    }
}
