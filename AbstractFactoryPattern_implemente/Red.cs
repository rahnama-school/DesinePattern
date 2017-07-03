using System;

namespace AbstractFactoryPattern_implemente
{
    public class Red : Icolor
    {
        public void Fill()
        {
            Console.WriteLine("fill red ");
        }
    }
}