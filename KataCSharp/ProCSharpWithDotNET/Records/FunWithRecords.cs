using System.Data.Common;
using System;
namespace KataCSharp.ProCSharpWithDotNET.Records;

public class FunWithRecords
{
    public void Start()
    {
        var employee = new Employee("123456");
        var person1 = new Person(1, "Test", employee);

        var person1Copy = person1;
        Console.WriteLine("Are reference equal:  " + ReferenceEquals(person1, person1Copy));

        var person2 = new Person(1, "Test", employee);
        Console.WriteLine("Is person1.Equals(person2) equal:  " + person1.Equals(person2));

        person1.Id = 2;
        Console.WriteLine("Is person1.Equals(person2) equal after update:  " + person1.Equals(person2));

        var person3 = new PersonPositionalParameters(1, "Test", employee);
        var (id, x2,x3) = person3;

        Console.ReadLine();
    }
}

record Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Employee Employee { get; set; }

    public Person(int id, string name, Employee employee)
    {
        Id = id;
        Name = name;
        Employee = employee;
    }

}

record PersonPositionalParameters(int Id, string Name, Employee Employee);

record Employee(string PhoneNumber);