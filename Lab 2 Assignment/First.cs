using System;
namespace Lab2
{
    public class Lab21
    {
        string name;
        int age;
        double salary;
        public Lab21(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Age : " + age);
            Console.WriteLine("Employee Salary : " + salary);
        }
        public static void Main(string[] args)
        {
            Lab21 a1 = new Lab21("Raghav", 23, 50000);
            a1.display();
        }
    }
}