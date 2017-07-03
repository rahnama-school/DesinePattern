using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern_implemente
{
  public  class Rectangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("draw Rectangle");
        }

    }
}
