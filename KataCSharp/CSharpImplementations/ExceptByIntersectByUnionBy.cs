namespace KataCSharp.CSharpImplementations;

public class ExceptByIntersectByUnionBy
{

	public void Start()
	{
		var exceptByImplementation = new ExceptByImplementation();
		exceptByImplementation.Test();

		var intersectByImplementation = new IntersectByImplementation();
		intersectByImplementation.Test();
	}

}

public class ExceptByImplementation
{

	List<Person> candidates = new List<Person>
	{
		new Person() { SSN="1234567890", Name="John Doe" },
		new Person() { SSN="1234567891", Name="Jane Doe" },
		new Person() { SSN="1234567892", Name="Emily Johnson" },
		new Person() { SSN="1234567893", Name="William Brown" },
		new Person() { SSN="1234567894", Name="Sarah Davis" },
	};

	List<Person> employees = new List<Person>
	{
		new Person() { SSN="1234567890", Name="John Doe" },
		new Person() { SSN="1234567891", Name="Jane Doe" }
	};

	public void Test()
	{
		
		var nonDuplicationgElements = candidates.Except(employees);

		var potentialCandidates = candidates.ExceptBy(
				employees.Select(e => e.SSN),
				e => e.SSN
		);

		var noCandidates = employees.ExceptBy(
				candidates.Select(e => e.SSN),
				e => e.SSN
		);

		foreach (var candidate in potentialCandidates)
		{
			Console.WriteLine(candidate);
		}

	}
}


public class IntersectByImplementation
{
	List<Person> candidates = new List<Person>
	{
		new Person() { SSN="1234567890", Name="John Doe" },
		new Person() { SSN="1234567891", Name="Jane Doe" },
		new Person() { SSN="1234567892", Name="Emily Johnson" },
		new Person() { SSN="1234567893", Name="William Brown" },
		new Person() { SSN="1234567894", Name="Sarah Davis" },
	};

	List<Person> employees = new List<Person>
	{
		new Person() { SSN="1234567890", Name="John Doe" },
		new Person() { SSN="1234567891", Name="Jane Doe" }
	};

	public void Test()
	{
		var duplicatingElements = employees.IntersectBy(candidates.Select(c => c.SSN), k => k.SSN);
		foreach (var item in duplicatingElements)
		{
            Console.WriteLine(item);
		}

	}
}
