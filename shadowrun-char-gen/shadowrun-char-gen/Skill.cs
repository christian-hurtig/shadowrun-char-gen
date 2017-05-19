using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowrun_char_gen {
    class Skill {
        string name;
        Attribute baseAttribute;
        int rank;
        SkillGroup skillgroup;

        public Skill(string name, Attribute baseAttribute, int rank, SkillGroup skillgroup) {
            this.name = name;
            this.baseAttribute = baseAttribute;
            this.rank = rank;
            this.skillgroup = skillgroup;
        }

        public void improve() {
            if(skillgroup.rank == 0) {
                rank++;
            }
        }

        public void decrease() {
            if(skillgroup.rank == 0) {
                rank--;
            }
        }
    }
}
