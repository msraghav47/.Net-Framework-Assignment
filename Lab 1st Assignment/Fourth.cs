using System;
namespace labfirst4
{
    class Fourth
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5];
            Console.WriteLine("Enter the element of array : ");
            for (int i = 0; i < 5; i++) Arr[i] = Convert.ToInt32(Console.ReadLine());
            int oddcount=0,evencount = 0;
            for (int i = 0; i < 5; i++)
            {
                if (Arr[i]%2==0)
                    evencount++;
                else
                {
                    oddcount++;
                }
            }
            Console.WriteLine("Odd elements in array : " + oddcount);
            Console.WriteLine("Even elements in array : "+ evencount);
        }
    }
}