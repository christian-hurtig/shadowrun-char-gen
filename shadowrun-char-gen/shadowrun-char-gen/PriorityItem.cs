using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowrun_char_gen
{
    public class PriorityItem
    {
        public char Index { get; set; }
        public string Text { get; private set; }

        public PriorityItem(char index, string text) {
            Index = index;
            Text = text;
        }
    }
}
