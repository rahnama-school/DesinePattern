using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern_implemente
{
  public  class ColorFactory:AbstractFactory
    {
     public override Icolor GetColor(AbstractFactory.ColorType color)
        {
            if (color == ColorType.blue)
            {
                return new Blue();
            }
            if (color == ColorType.red)
            {
                return new Red();
            }
            return null;
        }

        public override IShape GetShape(ShapeType shape)
        {
            throw new NotImplementedException();
        }
    }
}
