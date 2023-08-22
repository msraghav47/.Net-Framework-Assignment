using System;
namespace LabFirst7
{
    class Seven
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter Elements to be search");
            int n = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("Element found at index :" + i);
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Element not found");
            Console.ReadLine();


        }
    }
}