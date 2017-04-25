using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowrun_char_gen {
    public class Race {
        public string name;
        Attribute BodyMax;
        Attribute AgilityMax;
        Attribute ReactionMax;
        Attribute StrengthMax;
        Attribute WillpowerMax;
        Attribute LogicMax;
        Attribute IntuisionMax;
        Attribute CharismaMax;
        Attribute EdgeMax;
        Attribute MagicMax;
        Attribute ResonanceMax;

        public Race(string name, int bodyMax, int agilityMax, int reactionMax, int strengthMax, int willpowerMax,
                    int logicMax, int intuitionMax, int charismaMax, int edgeMax, int magicMax, int resonanceMax) {
            this.name = name;
            BodyMax = new Attribute(bodyMax);
            AgilityMax = new Attribute(agilityMax);
            ReactionMax = new Attribute(reactionMax);
            StrengthMax = new Attribute(strengthMax);
            WillpowerMax = new Attribute(willpowerMax);
            LogicMax = new Attribute(logicMax);
            IntuisionMax = new Attribute(intuitionMax);
            CharismaMax = new Attribute(charismaMax);
            EdgeMax = new Attribute(edgeMax);
            MagicMax = new Attribute(magicMax);
            ResonanceMax = new Attribute(resonanceMax);
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
