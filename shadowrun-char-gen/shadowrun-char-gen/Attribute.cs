using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowrun_char_gen
{
    class Attribute
    {
        public int Value { get; private set; }
        public int Maximum { get; private set; }

        public Attribute(int maximum)
        {
            Maximum = maximum;
            Value = StartValue();
        }

        private int StartValue() {
            return Math.Max(Maximum - 5, 1);
        }

        public int AugmentedMaximum() {
            return Maximum + 4;
        }
    }
}
