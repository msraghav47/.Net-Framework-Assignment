using System;
namespace labfirst5
{
    class fifth
    {
        static void Main(string[] args)
        {
            int[] Arr = { 45, 67, 32, 78, 89 };
            Console.WriteLine("The original array : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(Arr[i] + " ");
            }
            int k = 0;
            int[] reArr = new int[5];
            for (int i=4;i>=0;i--)
            {
                reArr[k++] = Arr[i];
            }
            Console.WriteLine("\nAfter reverse The  array : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(reArr[i] + " ");
            }
        }
    }
}