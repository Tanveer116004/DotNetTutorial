using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTutorial
{
    public class Program8
    {
        
        public static void Main(String[] args)
        {
            //string[] cars = new string[4];
            //Console.WriteLine("Insert 4 string values");
            //for (int i = 0; i < cars.Length; i++) {
            //    cars[i]=Console.ReadLine();
            //}
            //foreach(String str in cars)
            //{
            //    Console.WriteLine(str);
            //}
            //Console.ReadLine();
            Program8 program = new Program8();
            
            program.MultiDimensionArray();
        }

        public void MultiDimensionArray()
        {
            int[,] intArray = new int[2, 5] { { 1, 5, 3, 6, 8 }, { 2, 5, 3, 8, 6 } };
            for (int i = 0; i < 2; i++)//rows
            {
                for (int j = 0; j < 5; j++)//columns
                {
                    Console.WriteLine("Value of " + i + " & " + j + " is :" + intArray[i, j]);
                }
            }
        }

    }
}
