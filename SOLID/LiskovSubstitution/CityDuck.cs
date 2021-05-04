using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class CityDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("City duck swim");
        }

        public override void Quack()
        {
            Console.WriteLine("City duck quack");
        }

        public override void Fly()
        {
            Console.WriteLine("City duck flies");
        }
    }
}
