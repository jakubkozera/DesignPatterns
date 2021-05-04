using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Rectangle
    {
        protected int _height;
        protected int _width;

        public virtual void SetHeight(int height)
        {
            _height = height;
        }

        public virtual void SetWidth(int width)
        {
            _width = width;
        }
    }
}
