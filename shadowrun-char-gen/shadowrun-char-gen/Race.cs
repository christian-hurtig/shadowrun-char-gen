using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowrun_char_gen {
    public class Race {
        public string name;
        public Attribute Body;
        public Attribute Agility;
        public Attribute Reaction;
        public Attribute Strength;
        public Attribute Willpower;
        public Attribute Logic;
        public Attribute Intuision;
        public Attribute Charisma;
        public Attribute Edge;
        public Attribute Magic;
        public Attribute Resonance;

        public Race(string name, int bodyMax, int agilityMax, int reactionMax, int strengthMax, int willpowerMax,
                    int logicMax, int intuitionMax, int charismaMax, int edgeMax, int magicMax, int resonanceMax) {
            this.name = name;
            Body = new Attribute(bodyMax);
            Agility = new Attribute(agilityMax);
            Reaction = new Attribute(reactionMax);
            Strength = new Attribute(strengthMax);
            Willpower = new Attribute(willpowerMax);
            Logic = new Attribute(logicMax);
            Intuision = new Attribute(intuitionMax);
            Charisma = new Attribute(charismaMax);
            Edge = new Attribute(edgeMax);
            Magic = new Attribute(magicMax);
            Resonance = new Attribute(resonanceMax);
        }

        public string Name {
            get {
                return this.name;
            }

            private set {
                name = value;
            }
        }

    }
}
