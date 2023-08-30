using System;
namespace Lab26
{
    public  partial class Employee
    {
        public void calSalary(double HRA, double Basics, double Others)
        {
            double Salary = HRA+Basics+Others;
            Console.WriteLine("Employee Salary : "+Salary);
        }
        public static void Main(string[] args)
        {
            Employee e = new Employee("Raghav", 24, "CS");
            e.EmployeeDetail();
            e.calSalary(10000, 70000, 20000);
        }
    }
}
