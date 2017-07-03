using System;

namespace AbstractFactoryPattern_implemente
{
    public class ColorFactory : AbstractFactory
    {
        public override Icolor GetColor(ColorType color)
        {
            if (color == ColorType.blue)
                return new Blue();
            if (color == ColorType.red)
                return new Red();
            return null;
        }

        public override IShape GetShape(ShapeType shape)
        {
            throw new NotImplementedException();
        }
    }
}