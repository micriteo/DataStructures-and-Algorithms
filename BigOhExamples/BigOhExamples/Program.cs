using System;

namespace BinarySearch
{
    //Complexity of Program O(log n)
    class Program
    {
        static void Main(string[] args)
        {
            //The list that will be searched
            int[] arr = new int[] { 16, 27, 43, 45, 56, 67, 78, 89, 90, 100 };
            //The number we are searching for
            int target = 43;
            int result = BinarySearch(arr, target);
            Console.WriteLine("Index of " + target + " is " + result);
        }
        
        static int BinarySearch(int[]arr, int target)
        {
            //Setting the left margin
            int left = 0;
            //Setting the right margin
            int right = arr.Length - 1;
            //While the left margin is less than the right margin
            while (left <= right)
            {
                //if the left margin is less than the right margin
                //we setup a middle margin
                int middle = (left + right) / 2;
                //If the middle margin is the value that we are searching for then the programme stops
                if (arr[middle] == target)
                {
                    return middle;
                }
                // if the number is bigger then the middle then the left border becomes middle + 1
                else if (arr[middle] < target)
                {
                    left = middle + 1;
                }
                // if the number that we are looking is lower then the middle then the right border becomes middle - 1
                else
                {
                    right = middle - 1;
                }
            }
            //If the value we are looking for has not been found then -1 is returned 
            return -1;
            }
        }
    }
    
