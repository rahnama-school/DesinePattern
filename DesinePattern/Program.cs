using System;

namespace DesinePattern
{
    internal class Program
    {
        private static void Main()
        {
            IShape shape1 = FactoryShape.GetsShape(FactoryShape.shaypeType.Cricle);
            IShape shape2 = FactoryShape.GetsShape(FactoryShape.shaypeType.Rectangle);
            shape1.draw();
            shape2.draw();
            Console.ReadLine();
        }
    }
}