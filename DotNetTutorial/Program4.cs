using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTutorial
{
    class Program4
    {
        public static void IfExample(int i,int j) {
            if (i > j) {
                Console.WriteLine("If Example function -> {0} is greater than {1}", i, j);
            }
        }

        public static void IfElseExample(int i, int j) {
            if (i > j) {
                Console.WriteLine("If Else Example function -> {0} is greater than {1}", i, j);
            }
            else
            {
                Console.WriteLine("If Else Example function -> {0} is smaller than {1}", i, j);
            }
        }

        public static void IfElseLadderExample(int i, int j) {
            if (i > j)
            {
                Console.WriteLine("If Else Ladder Example function -> {0} is greater than {1}", i, j);
            }
            else if (j > i)
            {
                Console.WriteLine("If Else Ladder Example function -> {0} is smaller than {1}", i, j);
            }
            else if (i == 0)
            {
                Console.WriteLine("If Else Ladder Example function -> {0} is zero", i);
            }
            else if (j == 0)
            {
                Console.WriteLine("If Else Ladder Example function -> {0} is zero", j);
            }
            else {
                Console.WriteLine("If Else Ladder Example function -> {0} is equal to {1}", i, j);
            }
        }

        public static void SwitchExample(int i) {
            Console.WriteLine("SwitchExample function");
            switch (i)
            {
                case 0: Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:Console.WriteLine("Wrong input");
                    break;
            }
        }

        public static void TernaryOperator(int i, int j) {
            string result = i > j 
                ? "" + i + " is greater than " + j 
                : "" + i + " is smaller than " + j;
            Console.WriteLine(result);
        }
        public void Example() {
            IfExample(4, 3);
            IfExample(4, 15);
            IfElseExample(4, 3);
            IfElseExample(4,15);
            IfElseExample(4, 4);
            IfElseLadderExample(4, 3);
            IfElseLadderExample(4, 15);
            IfElseLadderExample(0, 0);
            IfElseLadderExample(4, 4);
            SwitchExample(5);
            SwitchExample(8);
            TernaryOperator(4, 5);
        }
    }
}
