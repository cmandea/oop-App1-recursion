

using System.Reflection.Metadata.Ecma335;

namespace oop_App1_recursion
{
    internal class Fibonacci
    {
        public static string FibonacciRec
         (
          int number1,
          int number2,
          int i,
          int sizeNumber
         )
        {
            string returnString="";
            if (i <= sizeNumber)
            {
                //Console.Write("{0} ", firstnumber);
                 returnString = number1.ToString();

                returnString = returnString + " " + FibonacciRec(number2, number1 + number2, i + 1, sizeNumber);
            }
            return returnString;
        }
    }
}
