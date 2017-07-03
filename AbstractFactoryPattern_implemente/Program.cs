using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern_implemente
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = FactoryProducer.GetFactory(FactoryProducer.objType.Shape);
            IShape shape = shapeFactory.GetShape(AbstractFactory.ShapeType.Rectangle);
            shape.Draw();
            IShape shape2 = shapeFactory.GetShape(AbstractFactory.ShapeType.Cricle);
            shape2.Draw();

            AbstractFactory Colorfactory = FactoryProducer.GetFactory(FactoryProducer.objType.Color);
            Icolor myColor = Colorfactory.GetColor(AbstractFactory.ColorType.blue);
            myColor.Fill();
            Icolor myColor2 = Colorfactory.GetColor(AbstractFactory.ColorType.red);
            myColor2.Fill();
            Console.ReadLine();



        }
    }
}
