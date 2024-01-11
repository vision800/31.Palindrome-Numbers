using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Palindrome_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number To Check Palindrome : ");
            int number = int.Parse(Console.ReadLine());
            int remainder, sum = 0;

            //store the number in temporary variable
            int temp = number;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                remainder = number % 10;
                //multiply the sum with 10 and then add the remainder
                sum = (sum * 10) + remainder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
               
            }

            //check if the temporary value is equal to sum value
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
