using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern_implemente
{
    public abstract class AbstractFactory
    {
        public enum ShapeType
        {
            Rectangle,
            Cricle
        }
        public enum ColorType
        {
            red, blue
        }
        public abstract Icolor GetColor(ColorType color);
        public abstract IShape GetShape(ShapeType shape);



    }
}
