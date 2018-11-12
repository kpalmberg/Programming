/*
 * Author: Kevin Palmberg
 * Date: 1/21/2018
 * Description: Includes a function in C# that determines if a given number is prime. Just to test, a for loop has been ran 
 * to verify that all the prime number from 0-100 have been printed out correctly.
 */

using System;

namespace PrimeNumberChecker
{
    class Program
    {
        static bool IsPrime(int someNumber) //Returns true if number is prime, false if not
        {
            if(someNumber <=1) //Prime number must be an a whole number greater than 1. Anything 1 or below immediately disqualified
            {
                return false;
            }
            else //For all numbers above 1
            {
                int i = 0; //index, out of for loop for later use
                for(i = 2; i <= someNumber -1; i++) //for all numbers between 2 and the number itself -1
                {
                    if(0 == someNumber % i) //try dividing by all these numbers, does no remainder exist? Is so, somenumber % i = 0, therefor number is not prime
                    {
                        return false;
                    }
                }
                if(i == someNumber) //After checking all the number between 2 and the number itself -1, i should be equal to the number itself at this point if prime
                {
                    return true;
                }
                return false; //have to have a return value for all cases. If it fails the if statement above, it's not going to be prime, so return false.
            }
        }

        static void Main(string[] args)
        {
            int n = 100; //Whatever number you want to run the for loop to

            Console.WriteLine("Displaying all prime numbers between 0 and " + n + ".");

            for (int i = 0; i <= n; i++)
            {
                if(IsPrime(i) == true) //If the number proves to be true, we'll print the number to the console
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}