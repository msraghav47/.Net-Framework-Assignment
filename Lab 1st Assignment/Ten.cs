using System;
namespace LabFirst10
{
    class Ten
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr2 = new int[5];
            int j = 0;
            int[] arr3 = new int[5];
            Console.WriteLine("Enter 5 Elements of First Array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter 5 Elements of second Array");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr2.Length; k++)
                {
                    if (arr[i] == arr2[k])
                    {
                        arr3[j] = arr[i];
                        j++;
                    }
                }

            }
            Console.WriteLine("Final Array with Common Elements are:");
            for (int i = 0; i < j; i++)
            {
                Console.Write(arr3[i] + " ");

            }
        }
    }
}