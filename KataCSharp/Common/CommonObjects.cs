﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Common
{
    public class CommonObjects
    {
        public class Company
        {
            public int Id { get; set; }
            public string CompanyName { get; set; }
            public IEnumerable<Employee> Employees { get; set; }
        }

        public class Employee : IEquatable<Employee>, IComparable<Employee>
		{
            public int Id { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public IEnumerable<Phone> Phones { get; set; }

			public int CompareTo(Employee? other) => CompareTo(other);

			public bool Equals(Employee? other)
			{
                if (other == null)
                    return false;

                foreach (var phone in Phones)
                {
                    var isEqual = other.Phones.Any(el => phone.Equals(el));

					if (!isEqual)
                        return false;
                }
                bool phonesEqual = Phones.OrderBy(p => p).SequenceEqual(other.Phones.OrderBy(p => p));

                return phonesEqual 
                    && Name == other.Name 
                    && Position == other.Position;
			}
		}

        public class Phone : IEquatable<Phone>, IComparable<Phone>
		{
            private string? _number;

            public string Number
            {
                get { return _number; }
                set { _number = value; }
            }

            public int CompareTo(Phone? other) { return this.Number.CompareTo(other.Number); }

			public bool Equals(Phone? other)
			{
                if (other == null) return false;

                return Number == other.Number;
			}
		}

        public class Name
        {
            public string CompanyName { get; set; }
            public string EmployeeName { get; set; }
        }

        public static List<Employee> CreateEmployees()
        {
            Employee emp11 = new Employee()
            {
                Id = 1,
                Name = "Misho",
                Position = "HR",
                Phones = new List<Phone>() { new Phone { Number = "088 1234567" }, new Phone { Number = "0000000000" } }
            };
            Employee emp12 = new Employee()
            {
                Id = 2,
                Name = "Stef",
                Position = "HR",
                Phones = new List<Phone>() { new Phone { Number = "088 77777777" }, new Phone { Number = "1111111111" } }
            };
            Employee emp21 = new Employee()
            {
                Id = 3,
                Name = "Tosho",
                Position = "IT",
                Phones = new List<Phone>() { new Phone { Number = "0899999999" } }
            };
            Employee emp22 = new Employee()
            {
                Id = 4,
                Name = "Qnko",
                Position = "IT",
                Phones = new List<Phone>() { new Phone { Number = "088 8888888888888" }, new Phone { Number = "22222222222" } }
            };

            return new List<Employee>() { emp11, emp12, emp21, emp22 };
        }
        public static List<Company> CreateCompanies()
        {

            var employees = CreateEmployees().ToArray();

            var companies = new List<Company> {
                new Company { CompanyName="Nestle", Employees = new List<Employee>{ employees[0], employees[2] }},
                new Company { CompanyName="Milka", Employees = new List<Employee>{employees[1], employees[3]}}
            };

            return companies;
        }

        public class Grocery
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public GroceryTypeEnum Type { get; set; }
        }

        public static List<Grocery> BuildGroceries()
        {
            return new List<Grocery> {
                new Grocery {
                    Id = 1,
                    Name = "Danone",
                    Type = GroceryTypeEnum.BEVARAGE
                },new Grocery {
                    Id = 2,
                    Name = "Pork",
                    Type = GroceryTypeEnum.MEAT
                },new Grocery {
                    Id = 3,
                    Name = "Burger beans",
                    Type = GroceryTypeEnum.BREAD
                },new Grocery {
                    Id = 4,
                    Name = "Water",
                    Type = GroceryTypeEnum.BEVARAGE
                },
            };
        }

        public enum GroceryTypeEnum
        {
            MEAT,
            BEVARAGE,
            BREAD,

        }
    }
}
