using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.CSharpImplementations
{
    public class CommonObjects
    {
        public class Company
        {
            public string CompanyName { get; set; }
            public IEnumerable<Employee> Employees { get; set; }
        }
        public class Employee
        {
            public string Name { get; set; }
            public IEnumerable<Phone> Phones { get; set; }
        }
        public class Phone
        {
            public string Number { get; set; }
        }

        public class Name
        {
            public string CompanyName { get; set; }
            public string EmployeeName { get; set; }
        }

        public List<Employee> CreateEmployees()
        {
            Employee emp11 = new Employee()
            {
                Name = "Misho",
                Phones = new List<Phone>() { new Phone { Number = "088 1234567" }, new Phone { Number = "0000000000" } }
            };
            Employee emp12 = new Employee()
            {
                Name = "Stef",
                Phones = new List<Phone>() { new Phone { Number = "088 77777777" }, new Phone { Number = "1111111111" } }
            };
            Employee emp21 = new Employee()
            {
                Name = "Misho",
                Phones = new List<Phone>() { new Phone { Number = "088 1234567" }, new Phone { Number = "0000000000" } }
            };
            Employee emp22 = new Employee()
            {
                Name = "Stef",
                Phones = new List<Phone>() { new Phone { Number = "088 77777777" }, new Phone { Number = "1111111111" } }
            };



            return new List<Employee>() { emp11, emp12 };
        }
        public List<Company> CreateCompanies()
        {
            Employee emp11 = new Employee()
            {
                Name = "Misho",
                Phones = new List<Phone>() { new Phone { Number = "088 1234567" }, new Phone { Number = "0000000000" } }
            };
            Employee emp12 = new Employee()
            {
                Name = "Stef",
                Phones = new List<Phone>() { new Phone { Number = "088 77777777" }, new Phone { Number = "1111111111" } }
            };
            Employee emp21 = new Employee()
            {
                Name = "Tosho",
                Phones = new List<Phone>() { new Phone { Number = "088 1234567" }, new Phone { Number = "0000000000" } }
            };
            Employee emp22 = new Employee()
            {
                Name = "Qn",
                Phones = new List<Phone>() { new Phone { Number = "088 77777777" }, new Phone { Number = "1111111111" } }
            };

            var companies = new List<Company> {
                new Company { CompanyName="Nestle", Employees = new List<Employee>{emp11,emp12}},
                new Company { CompanyName="Milka", Employees = new List<Employee>{emp21,emp22}}
            };

            return companies;
        }
    }
}
