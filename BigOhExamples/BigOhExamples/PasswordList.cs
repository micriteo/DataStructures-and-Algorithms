namespace BinarySearch;
using System;
using System.Security.Cryptography;

public class PasswordList
{
    // Function to generate permutations of
    // at most X elements from array arr[]
    public static void Generate(int X, List<string> arr)
    {
        List<string> ml = arr;
        
        for (int i = 0; i < ml.Count; i++)
        {
            Console.Write(ml[i] + " ");
        }

        int count = ml.Count;

        // Traverse all possible lengths
        for (int z = 0; z < X - 1; z++)
        {
            // Stores all combinations
            // of length z
            List<string> tmp = new List<string>();

            // Traverse the array
            for (int i = 0; i < arr.Count; i++)
            {
                for (int k = 0; k < ml.Count; k++)
                {
                    if (arr[i] != ml[k])
                    {
                        // Generate all
                        // combinations of length z
                        tmp.Add(ml[k] + arr[i]);
                        count += 1;
                    }
                }
            }

            // Print all combinations of length z
            for (int i = 0; i < tmp.Count; i++)
            {
                Console.Write(tmp[i] + " ");
            }

            // Replace all combinations of length z - 1
            // with all combinations of length z
            ml = tmp;
        }
    }
}