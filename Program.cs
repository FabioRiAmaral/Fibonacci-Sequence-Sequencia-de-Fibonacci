using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which number in which position of the Fibonacci sequence do you want to obtain?"); 
            string userInput = Console.ReadLine(); // ask the user for a position in the fibonacci sequence and then store in a local viariable
            int userInputNumber = Convert.ToInt32(userInput);
            
            int[] sequence = Fibonacci(userInputNumber); // calls the method to calculate the Fibonacci sequence

            Console.WriteLine($"\nThe {userInputNumber}th number of the fibonacci sequence is {sequence[userInputNumber - 1]}!\n"); // print the result and jump one 
                                                                                                                                    // line for the next print
            Console.Write("The complete sequence is: "); // print all the sequence of Fibonacci created
            foreach (var a in sequence)
                Console.Write(a + " ");
        } 

        static int[] Fibonacci(int repeat) 
        {
            int[] allSequence = new int[repeat];
            int a = 1; // first number of fibonacci
            int b = 1; // second number of fibonacci

            for (int x = 0; x <= repeat - 2; x++) // make the recursive function that calculate the Fibonacci
            {               
                allSequence[x] = a; // adds all the numbers of Fibonacci at the array "allSequence"

                int fibonaci = a + b; // The next Fibonacci number will always be the sum of the two last
                a = b;
                b = fibonaci;                 
            }
            allSequence[repeat - 1] = b; // after the loop ends assing the last space in the array to the last Fibonacci sequence calculated
            return allSequence; // return the array with all the sequence until the user input position
        }
    }
}
