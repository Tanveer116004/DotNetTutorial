using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTutorial
{
    class Program6
    {
        public void BoxingExample()
        {
            int i = 5;
            object o = i;
            Console.WriteLine("As per boxing example value of object o is: " + o);
        }

        public void UnBoxingExample()
        {
            object o = 10;
            int i = Convert.ToInt32(o);     //OR BY (int)o
            Console.WriteLine("As per unboxing example value of int i is " + i);
        }
    }
}
