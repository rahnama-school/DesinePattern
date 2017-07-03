namespace AbstractFactoryPattern_implemente
{
    public abstract class AbstractFactory
    {
        public enum ColorType
        {
            red,
            blue
        }

        public enum ShapeType
        {
            Rectangle,
            Cricle
        }

        public abstract Icolor GetColor(ColorType color);
        public abstract IShape GetShape(ShapeType shape);
    }
}