using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowrun_char_gen
{
    public class Attribute
    {
        int Value;
        int Maximum;

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

        public string getMinMaxString() {
            return Value + "/" + Maximum;
        }
    }
}
