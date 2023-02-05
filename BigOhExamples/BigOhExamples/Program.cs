using System;

namespace BinarySearch
{
    //Complexity of Program O(log n)
    class Program
    {
        static void Main(string[] args)
        {
            // Adding two numbers ??
            // Complexity O(1)
            int a = 5;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine("INCREDIBLE!");

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


            // Quick Sort
            // Complexity O(n log n)

            //Providing an unsorted list 
            int[] arr2 = { 23, 7, 8, 30, 1, 6 };
            // Getting the length of the array;
            int n = arr2.Length;


            QuickSort(arr2, 0, n - 1);

            Console.WriteLine("Sorted array is: ");
            for (int i = 0; i < n; ++i)
                Console.Write(arr2[i] + " ");

            Console.WriteLine();
            // Password list generator
            // Complexity O(n^2)
            Console.WriteLine("Enter a number");
            int number_v_two = Int32.Parse(Console.ReadLine());
            PasswordList.Generate(number_v_two, new List<string> { "a", "b", "c" });
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

        public static int Partition(int[] arr2, int low, int high)
        {
            // Choose the pivot value
            int pivot = arr2[high];

            // Initialize the index of the pivot element
            int i = (low - 1);

            // Loop through all elements in the sub-array
            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than or equal to the pivot,
                // swap it with the element at index i + 1.
                if (arr2[j] <= pivot)
                {
                    i++;

                    int temp = arr2[i];
                    arr2[i] = arr2[j];
                    arr2[j] = temp;
                }
            }

            // Swap the pivot element with the element at index i + 1
            int temp1 = arr2[i + 1];
            arr2[i + 1] = arr2[high];
            arr2[high] = temp1;

            // Return the index of the pivot element
            return i + 1;
        }

        public static void QuickSort(int[] arr2, int low, int high)
        {
            // If the low index is less than the high index,
            // partition the sub-array and sort both halves recursively.
            if (low < high)
            {
                int pi = Partition(arr2, low, high);

                QuickSort(arr2, low, pi - 1);
                QuickSort(arr2, pi + 1, high);
            }
        }
    }
}
    
