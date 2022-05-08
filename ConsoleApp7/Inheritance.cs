using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine("Employee Name: "+FirstName + " " + LastName + "\nEmployee Email: " + Email);
        }
    }
   

    public class FullTimeEmployee : Employee
    {
        public double YearlySalary { get; set; }

        public  void FullEmployee()
        {
            Console.WriteLine("Employee Monthly Salary: " + YearlySalary/12 +"\nEmployee Yearly Salary: "+ YearlySalary);
        }

    }
    public class PartTimeEmployee : Employee
    {
        public double HourlySalary { get; set; }
        public int DailyWorkHour  {get; set;}
         
        public void PTEmployee()
        {
            Console.WriteLine("Employee Work Hour: "+DailyWorkHour +"\nEmployee Per Day Salary:"+HourlySalary*DailyWorkHour);
        }
    }

}
