using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();

            var circle = shapeFactory.CreateShape(ShapeType.Circle);

            circle.Render();

            var triangle = shapeFactory.CreateShape(ShapeType.Triangle);

            triangle.Render();
        }
    }
}
