using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTutorial
{
    class Program5
    {
        public void sortArrayExample(int[] intArray) {
            Array.Sort(intArray);
        }

        public void convertSingleLineInputToArray() {
            int[] intArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
        }
        public void ArrayExample()
        {
            int[] intArray = new int[10] { 1,5,8,7,3,4,12,6,9,7};
            
            sortArrayExample(intArray);
            
            foreach(int i in intArray)
            {
                Console.WriteLine(i);
            }

            string[] stringArray = new string[5];
            
            for (int i = 0; i < 5; i++) {
                Console.Write("Enter a string: ");
                stringArray[i]=Console.ReadLine();
            }
            for (int i = 0; i < stringArray.Length; i++) {
                Console.WriteLine(stringArray[i]);
            }
        }

        public void MultiDimensionArray() {
            int[,] intArray = new int[2, 5] { { 1, 5, 3, 6, 8 }, { 2, 5, 3, 8, 6 } };
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++) {
                    Console.WriteLine("Value of "+i+" & "+j+" is :"+intArray[i,j]);
                }
            }
        }


        public void Example() {
            //ArrayExample();
            convertSingleLineInputToArray();
        }
    }
}
