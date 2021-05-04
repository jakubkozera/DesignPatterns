using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class RubberDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("Rubber duck swim");
        }

        public override void Quack()
        {
            Console.WriteLine("Rubber duck quack");
        }

        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
