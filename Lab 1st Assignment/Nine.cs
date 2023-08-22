using System;
namespace Labfirst9
{
    class nine
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 3, 3, 3, 4, 5, 5 };
            int l = arr.Length;
            int r = removeDuplicateFromArray(arr, l);

            Console.WriteLine("Final Array is:");
            for (int i = 0; i < r; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
        static int removeDuplicateFromArray(int[] arr, int n)
        {
            if (n == 0 || n == 1)
                return 0;

            int[] arr2 = new int[n];
            int j = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    arr2[j++] = arr[i];
                }

            }

            arr2[j++] = arr[n - 1];

            for (int i = 0; i < j; i++)
            {
                arr[i] = arr2[i];
            }

            return j;
        }
    }
}