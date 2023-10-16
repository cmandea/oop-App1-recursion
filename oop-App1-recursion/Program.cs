using System;

namespace oop_App1_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = ArrayHelper.ReadNumber("The size of array=", 3, 0);

           // int nrforOccurrance = ArrayHelper.ReadNumber("Please enter number for count of occurrance=", 3, 0);
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                int item = ArrayHelper.ReadNumber($"Element[{i}]=", 3, 0);
                array[i] = item;
            }
            ArrayHelper.PrintArray("Array=", array);

            if (array != null)
            {
                
                
                Console.WriteLine($"Min of the array =[{string.Join(",",array)}] is: "+ArrayHelper.readMinArray(array, 0, array[0]));
                Console.WriteLine($"Max of the array =[{string.Join(",", array)}] is: " + ArrayHelper.readMaxArray(array, 0, array[0]));
               
            }

            int sizeNumber = ArrayHelper.ReadNumber("The size of number of Fibonacci=", 3, 0);
            Console.WriteLine($"Recursion String of Fibonacci= " + Fibonacci.FibonacciRecursive(0, 1, 1, sizeNumber));
            

        }
    }
}