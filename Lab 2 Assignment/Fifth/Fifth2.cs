using System;
namespace Lab25
{
    public partial class Person
    {
        public void FullName()
        {
            Console.WriteLine("Full Name : " + First_name + " " + Last_name);
        }
        public static void Main(string[] args)
        {
            Person p = new Person("Mohit","Raghav");
            p.FullName();
        }
    }
}
