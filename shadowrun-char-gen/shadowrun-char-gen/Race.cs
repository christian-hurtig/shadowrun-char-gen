using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowrun_char_gen
{
    public class Race
    {
        string Name { get; }
        int BodyMax;
        int AgilityMax;
        int ReactionMax;
        int StrengthMax;
        int WillpowerMax;
        int LogicMax;
        int IntuisionMax;
        int CharismaMax;
        int EdgeMax;
        int MagicMax;
        int ResonanceMax;

        public Race(string name, int bodyMax, int agilityMax, int reactionMax, int strengthMax, int willpowerMax, 
                    int logicMax, int intuitionMax, int charismaMax, int edgeMax, int magicMax, int resonanceMax){
            Name = name;
            BodyMax = bodyMax;
            AgilityMax = agilityMax;
            ReactionMax = reactionMax;
            StrengthMax = strengthMax;
            WillpowerMax = willpowerMax;
            LogicMax = logicMax;
            IntuisionMax = intuitionMax;
            CharismaMax = charismaMax;
            EdgeMax = edgeMax;
            MagicMax = magicMax;
            ResonanceMax = resonanceMax;
        }
    }
}
