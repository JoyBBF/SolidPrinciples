using System;
using System.Collections.Generic;
using SolidPrinciples.Liskov;
using SolidPrinciples.SingleResponsibility;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            // LISKOV Failing
            var employeeList = new List<EmployeeBase>
            {
                new FreelancerEmployee(),
                new RegularEmployee()
            };

            PersonHandler.InsertPerson(new Person());
            
            foreach (var employee in employeeList)
            {
                System.Console.WriteLine(employee.GetEmployeeDetails(1245));
            }
        }
    }
}