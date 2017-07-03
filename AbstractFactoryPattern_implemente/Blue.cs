using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern_implemente
{
  public  class Blue :Icolor
    {
        public void Fill()
        {
            Console.WriteLine("fill blue");
        }
    }
}
