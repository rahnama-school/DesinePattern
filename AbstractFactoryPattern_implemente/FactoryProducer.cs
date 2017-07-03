namespace AbstractFactoryPattern_implemente
{
    public class FactoryProducer
    {
        //added just for clear code 
        public enum objType
        {
            Shape,
            Color
        }

        public static AbstractFactory GetFactory(objType obj)
        {
            if (obj == objType.Shape)
                return new ShapeFactory();
            if (obj == objType.Color)
                return new ColorFactory();
            return null;
        }
    }
}