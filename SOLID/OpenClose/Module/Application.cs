using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenClose.Class.Module
{
    public class Application
    {
        public void Render(List<Shape> shapes)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Render();
            }
        }
    }
}
