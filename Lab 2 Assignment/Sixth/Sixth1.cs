using System;
namespace Lab26
{
    public partial class Employee
    {
        string name;
        int age;
        string department;
        Employee(string name, int age, string department)
        {
            this.name = name;
            this.age = age;
            this.department = department;
        }
        public void EmployeeDetail()
        {
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Age : " + age);
            Console.WriteLine("Employee Department : " + department);
        }
    }
}