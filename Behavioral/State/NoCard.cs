using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoCard : State
    {
        public NoCard(Context context) : base(context)
        {
        }

        public override void InsertCard()
        {
            Console.WriteLine("Card inserted");
            _context.ChangeState(new CardInserted(_context));
        }

        public override void EjectCard()
        {
            Console.WriteLine("No card inserted yet");
        }

        public override void InsertPin(int pin)
        {
            Console.WriteLine("No card inserted yet");
        }

        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("No card inserted yet");
        }
    }
}
