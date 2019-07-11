using System;
using System.Collections.Generic;

namespace CompanyEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of Company
            Company company1 = new Company("Super Awesome Company", DateTime.Now);

            // Create 3 instances of Employee
            Employee employee1 = new Employee();
            employee1.firstName = "Joe";
            employee1.lastName = "Smith";
            employee1.title = "Manager";
            employee1.startDate = DateTime.Now;

            Employee employee2 = new Employee();
            employee2.firstName = "Jane";
            employee2.lastName = "Smartt";
            employee2.title = "Director";
            employee2.startDate = DateTime.Now;

            Employee employee3 = new Employee();
            employee3.firstName = "Sarah";
            employee3.lastName = "Jones";
            employee3.title = "Supervisor";
            employee3.startDate = DateTime.Now;

            // Assign employees to the company

            company1.employees = new List<Employee>();

            company1.employees.Add(employee1);
            company1.employees.Add(employee2);
            company1.employees.Add(employee3);

            company1.ListEmployees();
        }
    }
}
