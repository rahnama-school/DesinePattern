namespace DesinePattern
{
    public class FactoryShape
    {
        public enum shaypeType
        {
            Rectangle,
            Cricle
        }


        public static IShape GetsShape(shaypeType shaype)
        {
            if (shaype == shaypeType.Cricle)
                return new Cricle();
            if (shaype == shaypeType.Rectangle)
                return new Rectangle();
            return null;
        }
    }
}