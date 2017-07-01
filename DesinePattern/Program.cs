using System;

namespace DesinePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape shape = FactoryShape.GetsShape(FactoryShape.shaypeType.Cricle);
            IShape shape2 = FactoryShape.GetsShape(FactoryShape.shaypeType.Rectangle);
            shape.draw();
            shape2.draw();
            Console.ReadLine();


        }
    }
}
