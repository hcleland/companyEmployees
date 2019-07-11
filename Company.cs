using System;
using System.Collections.Generic;

namespace CompanyEmployees
{
    public class Company
    {
        // ----------- Private Properties -------------

        // -------- Public Properties -------------
        public string companyName { get; }
        public DateTime dateEstablished { get; }
        public List<Employee> employees { get; set; }

        // -------- Constructor -----------

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string companyName, DateTime dateEstablished)
        {
            this.companyName = companyName;
            this.dateEstablished = dateEstablished;
        }
        // ------- METHODS ---------- 
        public void ListEmployees()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName}");
            }

        }
    }

}