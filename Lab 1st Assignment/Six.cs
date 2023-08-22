using System;
namespace lab1st
{
    class Sum
    {
        static void Main(string[] args)
        {
            int[] Arr = {10,20,30,40,50};
            Console.WriteLine("The original array : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(Arr[i] + " ");
            }
            int num;
            Console.WriteLine("\nEnter any number for multiply in each element of array : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                Arr[i]= Arr[i]*num;
            }
            Console.WriteLine("The array after multiply : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(Arr[i] + " ");
            }
        }
    }
}