using System;

namespace AbstractFactoryPattern_implemente
{
    public class ShapeFactory : AbstractFactory
    {
        public override Icolor GetColor(ColorType color)
        {
            throw new NotImplementedException();
        }

        public override IShape GetShape(ShapeType shape)
        {
            if (shape == ShapeType.Rectangle)
                return new Rectangle();
            if (shape == ShapeType.Cricle)
                return new Cricle();
            return null;
        }
    }
}