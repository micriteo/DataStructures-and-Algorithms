using System;

namespace BinarySearch
{
    //Complexity of Program O(log n)
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Search Complexity O(log n)
            //The list that will be searched
            int[] arr = new int[] { 16, 27, 43, 45, 56, 67, 78, 89, 90, 100 };
            //The number we are searching for
            int target = 43;
            int result = BinarySearch(arr, target);
            Console.WriteLine("Index of " + target + " is " + result);


            //Looping through an ArrayList 
            //Complexity O(n)
            Console.WriteLine("Enter a number");
            int number = Int32.Parse(Console.ReadLine());
            string numbersShown = LoopArrayList(number);
            Console.WriteLine("The list of numbers created is  " + numbersShown);


            //Quick Sort
            //Complexity O(n log n)

            //Providing an unsorted list 
            int[] arr2 = { 23, 7, 8, 30, 1, 6 };
            //Getting the length of the array;
            int n = arr2.Length;


            QuickSort(arr, 0, n - 1);

            Console.WriteLine("Sorted array is: ");
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

        }

        public static int BinarySearch(int[] arr, int target)
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

        public static string LoopArrayList(int number)
        {
            string overview = "";
            for (int i = 0; i < number; i++)
            {
                overview += i + " ";
            }
            return overview;
        }


        
        static int Partition(int[] arr, int low, int high)
        {
            
            //Taking
            int pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
    }
}
    
