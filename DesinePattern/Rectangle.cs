using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesinePattern
{
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("rec draw");
        }
    }
}
