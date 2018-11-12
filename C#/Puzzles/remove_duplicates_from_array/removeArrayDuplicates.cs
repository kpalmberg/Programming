/*Author: Kevin Palmberg
 * Date: 1/21/2018
 * Description: C# program. Removes duplicates from an array. If the array is not given as a sorted array, the function will also sort 
 *              the array before proceeding to remove duplicates. It will then return the array without duplicates.
 */

using System;

namespace Remove_duplicates_from_array
{
    class Program
    {
        static int[] RemoveArrayDuplicates(int[] someArray) //removed duplicates from a sorted array
        {
            if (someArray.Length == 0) //check if array is empty, if so just return array, nothing to be sorted
            {
                return someArray; //just return array if it's empty...
            }
            else //ensure array is sorted
            {
                Array.Sort(someArray); //Sort array
            }

            int n = someArray.Length; //get array length
            int j = 0; //index tracker j

            for (int i = 0; i < n - 1; i++) //for every item in the array, with n-1 for 0 based indexing
            {
                if (someArray[i] != someArray[i + 1]) //If the current element is not equal to the next element in array
                {
                    someArray[j] = someArray[i]; //make j, the next spot in the array for the next unique element, whatever i is, which is the next unique element
                    j++; //incremement j to where the next unique element should be placed next time
                }
            }

            someArray[j++] = someArray[n - 1]; //Consider the last element

            Array.Resize(ref someArray, j); //resize array, removing duplicate entries at end of array

            return someArray; //return the array without duplicates
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] {5,4,1,8,3,1,4,7,8,4,2,3,3,3,3,6,9}; //example array

            arr = RemoveArrayDuplicates(arr); //make our array equal to the new no duplicates array by calling function

            foreach (int item in arr) //Print the array without duplicates
            {
                Console.WriteLine(item); //print all items
            }
        }
    }
}