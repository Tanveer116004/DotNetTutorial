using System;

namespace DotNetTutorial
{
    //Passing Value Type Variables
    class Program1
    {
        static void ChangeValue(int i) {
            i = 10;
            Console.WriteLine(i + " from Change Value function");
        }

        public void Example() {
            int i = 5;
            Console.WriteLine(i + " from Main before calling Change Value function");
            ChangeValue(i);
            Console.WriteLine(i + " from Main after calling Change Value function");
        }
    }
}
