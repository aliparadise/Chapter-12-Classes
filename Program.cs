using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create an instance of a company. Name it whatever you like.
            Company toysRUs = new Company("toysRUs", new DateTime(1, 1, 11));

            // Create three employees
            Employee Ali = new Employee()
            {
                FirstName = "Ali",
                LastName = "Paradise",
                Title = "CEO",
                StartDate = new DateTime(2012, 3, 11)
            };
            Employee John = new Employee()
            {
                FirstName = "John",
                LastName = "Doe",
                Title = "Trainee",
                StartDate = new DateTime(2019, 5, 27)
            };
            Employee Jane = new Employee()
            {
                FirstName = "Jane",
                LastName = "Smith",
                Title = "Consultant",
                StartDate = new DateTime(2016, 10, 5)
            };
            
            // Assign the employees to the company
            toysRUs.Employees.Add(Ali);
            toysRUs.Employees.Add(John);
            toysRUs.Employees.Add(Jane);
            /*
            
                Iterate the company's employee list and generate the
                simple report shown above
            */
            toysRUs.ListEmployees();
        }
    }
}
