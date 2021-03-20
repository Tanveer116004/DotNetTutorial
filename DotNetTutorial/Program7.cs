using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTutorial
{
    class Program7
    {
        public const int a=10;
        public readonly int b=15;
        public readonly int c;
        public Program7()
        {
            b = 20;
            c = 30;
            Console.WriteLine("a is {0:f2} b is {1} c is {2}", a, b, c);
            Console.WriteLine("a is " + a + " b is " + b + " c is " + c);
        }

        public void ConstAndReadOnlyExample()
        {
            //a=10;
            //b = 50;   
            //c=25;
            Console.WriteLine("cannot change value of const");
            Console.WriteLine("cannot change value of readonly in any function other than constructor");
        }

    }
}
