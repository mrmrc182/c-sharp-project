using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {

                Console.WriteLine("Please enter employee first name: (leave empty to exit): ");

                string firstName = Console.ReadLine();

                if (firstName == "")
                {
                    break;
                }
                Console.Write("Please enter employee last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Please enter Company Name: ");
                string companyName= Console.ReadLine();
                Console.Write("Please enter employee ID: ");
                int empId = Int32.Parse(Console.ReadLine());
                Console.Write("Please enter employee photo URL: ");
                string photoUrl = Console.ReadLine();
                Employee currentEmployee = new Employee(firstName, lastName, empId, photoUrl, companyName);
                employees.Add(currentEmployee);
            }
            return employees;
        }
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }
    }
}