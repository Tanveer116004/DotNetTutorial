using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTutorial
{
    class Program3
    {
        public void Example() {

            WhileExample();
            DoWhileExample();
            ForExample();
            ForEachExample();
            BreakandContinueExample();
        }

        static void WhileExample() {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Value of i from while loop is: " + i);
                i++;
            }
        }

        static void DoWhileExample() {
            int i = 0;
            do
            {
                Console.WriteLine("Value of i from do while loop is: " + i);
                i++;
            } while (i < 10);
        }

        static void ForExample() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Value of i from for loop is: " + i);
            }
        }

        static void ForEachExample()
        {
            int[] arr = new int[5] { 5, 8, 6, 15, 3 };
            foreach(int i in arr)
            {
                Console.WriteLine("Value of i in array from For each loop is: " + i);
            }
        }

        static void BreakandContinueExample() {
            Console.WriteLine("Hi from BreakandContinueExample");
            for (int i = 0; i < 10; i++) {
                if (i == 5) {
                    Console.WriteLine("Continue statement executed");
                    continue;
                }
                if (i == 8)
                {
                    Console.WriteLine("Break statement executed");
                    break;
                }
                Console.WriteLine("Value is :" + i);
            }
        }
    }
}
