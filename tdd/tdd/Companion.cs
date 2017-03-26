using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class Companion
    {
        public ICompanionState State { get; set; }

        public Companion(ICompanionState cstate)
        {
            State = cstate;
        }

        public Companion()
        {
            State = new DefaultState();
        }

        public string getWords(string words)
        {
            return State.getWords(this, words);
        }
    }
}
