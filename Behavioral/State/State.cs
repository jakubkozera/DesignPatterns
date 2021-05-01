using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class State
    {
        protected Context _context;

        protected State(Context context)
        {
            _context = context;
        }

        public abstract void InsertCard();
        public abstract void EjectCard();
        public abstract void InsertPin(int pin);
        public abstract void WithdrawCash(int amount);
    }
}
