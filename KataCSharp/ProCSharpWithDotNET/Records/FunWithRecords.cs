using System.Data.Common;
using System;
namespace KataCSharp.ProCSharpWithDotNET.Records;

public class FunWithRecords
{
    public void Start()
	{
		//RecordsEqualityAndDeconstruction();
		//RecordsInheritanceEquality();
		ClassesInheritanceEquality();
	}

	private static void RecordsInheritanceEquality()
	{
		var worker = new Worker(1, "Mark S.");
		var manager = new Manager(2, "Mr. Milchick", "Severed Floor");

		var human = new Human(2, "Helly R.");
		//var human2 = human with { Id = 2, Name = "Helly R." };
		//Console.WriteLine("human == human2: " + human.Equals(human2)); // true

		//var human3 = human with { Id = 3, Name = "Gemma" };
		//var human31 = new Human(3, "Gemma");
		//Console.WriteLine("human3 == human31: "+ human3.Equals(human31));// true
		//Console.WriteLine("human3 == human31: "+ ReferenceEquals(human3,human31));// false


		Console.WriteLine("human == manager " + human.Equals(manager));// False
		
		
		
		Console.ReadLine();
	}

	private static void ClassesInheritanceEquality()
	{
		var tiger = new Animal(AnimalTypeEnum.Mammal);
		var whiteGoat = new Goat();
		Console.WriteLine("Class tiger==whiteGoat " + tiger.Equals(whiteGoat));
		var t = tiger.GetType() == whiteGoat.GetType();
		Console.WriteLine("Class tiger==whiteGoat " + t);
	}

		
	private static void RecordsEqualityAndDeconstruction()
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
		var (id, x2, x3) = person3;
		person3.Deconstruct(out int id2, out string name, out Employee emp);
		//person3.Id = 3; // This will not work as records are immutable by default

		var personRecordStruct = new PersonRecordStruct(1, "Test", employee);
		personRecordStruct.Id = 3; // This will not work as record structs are immutable by default

		var personStruct = new PersonStruct(1, "Test", employee);
		var personStruct2 = new PersonStruct(1, "Test", employee);
		Console.WriteLine("Is personStruct.Equals(personStruct2) equal:  " + personStruct.Equals(personStruct2));


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

record struct PersonRecordStruct(int Id, string Name, Employee Employee);

struct PersonStruct(int Id, string Name, Employee Employee);

record Employee(string PhoneNumber);

record Human(int Id, string Name);

record Worker(int Id, string Name) : Human(Id,Name);
record Manager(int Id, string Name, string ManagedFloor) : Human(Id,Name);


class Animal
{
	public AnimalTypeEnum Type { get; set; }
	public Animal(AnimalTypeEnum type)
	{
		Type = type;
	}
}

class Goat : Animal
{
	public Goat() : base(AnimalTypeEnum.Mammal)
	{
		
	}

}

enum AnimalTypeEnum
{
	Mammal,
	Bird,
	Fish,
	Reptile,
	Amphibian,
}

