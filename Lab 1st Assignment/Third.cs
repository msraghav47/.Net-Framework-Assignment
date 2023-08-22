using System;
namespace labfirst3
{
    class third
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5];
            Console.WriteLine("Enter the element of array : ");
            for (int i = 0; i < 5; i++) Arr[i] = Convert.ToInt32(Console.ReadLine());
            int largest = Arr[0];
            for(int i=1;i<5;i++)
            {
                if (largest < Arr[i])
                    largest = Arr[i];
            }
            Console.WriteLine("the largest element in array : " + largest);
        }
    }
}