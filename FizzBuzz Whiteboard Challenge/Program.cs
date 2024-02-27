using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Whiteboard_Challenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Write a public method that accepts a number
            when the number is divisible by 3 return the word fizz

            when the number is divisible by 5 return the word buzz

            when the number is divisible by both, return the word fizzbuzz
            */
            Public string FizzBuzz(int number)
            {

                var answer = "";

                if (number % 3 == 0)
                {
                    answer = "fizz";
                }
                if (number % 5 == 0)
                {
                    answer += "buzz";
                }

                return answer;
            }
        }
    }
}
