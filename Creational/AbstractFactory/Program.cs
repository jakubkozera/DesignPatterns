using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var uiApplication = new Application(new MacFactory());

            uiApplication.RenderUI();
        }
    }
}
