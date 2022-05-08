using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTime = new FullTimeEmployee();

            Console.WriteLine("----------FullTime Employee Details----------");
            fullTime.FirstName = "Ayaz";
            fullTime.LastName = "Ahmad";
            fullTime.Email = "Ayaz123@gmail.com";
            fullTime.YearlySalary = 240000;
            fullTime.PrintFullName();
            fullTime.FullEmployee();


            Console.WriteLine("\n------------PartTime Employee Details----------"); 
            PartTimeEmployee partTime = new PartTimeEmployee();
            partTime.FirstName = "Ayaz";
            partTime.LastName = "Ahmad";
            partTime.Email = "Ayaz123@gmail.com";
            partTime.HourlySalary = 240;
            partTime.DailyWorkHour = 5;
            partTime.PrintFullName();
            partTime.PTEmployee();  

            

        }
    }
}
