using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            context.EjectCard();

            context.InsertCard();

            context.InsertPin(1111);

            context.InsertCard();

            context.InsertPin(8888);

            context.WithdrawCash(2000);

            context.InsertCard();

        }
    }
}
