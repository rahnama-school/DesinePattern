using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern_implemente
{
   public class Red:Icolor
    {
        public void Fill()
        {
            Console.WriteLine("fill red ");
        }
    }
}
