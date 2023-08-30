using System;
namespace Lab23
{
    public static class Mathhelper
    {
        public static double calavg(int[] arr)
        {
            double avg;
            int sum = 0;
            for(int i=0;i<arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            return avg;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the element of array : ");
            for(int i=0;i<size;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The average of all elements of array :"+Mathhelper.calavg(arr));
        }
    }
}