using System;

namespace AbstractFactoryPattern_implemente
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("draw Rectangle");
        }
    }
}