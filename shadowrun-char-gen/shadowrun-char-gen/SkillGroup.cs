using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowrun_char_gen {
    class SkillGroup {
        public string name;
        public int rank;

        public SkillGroup(string name) {
            this.name = name;
            rank = 0;
        }
    }
}
