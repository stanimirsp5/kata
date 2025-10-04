
using KataCSharp.LeetCode.B;
using KataCSharp.Recursion;
using System.Linq;

MyMain myMain = new MyMain();
myMain.Main();

// MyMainAsync main = new MyMainAsync();
// await main.RunMainAsync();

var t = null ?? "is null";
// shallow copy - yes
var listBase = new List<string>() { "test1", "test2", "test3", "test4" };
var listRef = listBase;
var listNoRef = new List<string>(listBase);

listBase.Remove("test1");

// deep copy - no
var filesBase = new List<File>() {
	new File { Id=1,Code="1", Name = "File 1"},
	new File { Id=2,Code="1", Name = "File 2"},
	new File { Id=3,Code="1", Name = "File 3"},
	new File { Id=4,Code="2", Name = "File 4"},
};
var distinctFiles = filesBase.OrderBy(el => el.Code).DistinctBy(el => el.Code).ToList();// distinct by keeps first ocurrance and removes following
var listFilesRef = filesBase;
var listFilesNoRef = new List<File>(filesBase);

filesBase[0].Code = "3";
filesBase[0] = new File { Id = 5, Code = "1111", Name = "File 5" };
filesBase.RemoveAt(0);

var filesTags = new List<File>() {
	new File { Id=1,Code="1", Name = "File 1"},
	new File { Id=2,Code="1", Name = "File 2"}
};
//, Tags = new List<Tag>{ { new Tag { Id = 1}}}  , Tags = new List<Tag>{ { new Tag { Id = 2}}}
var fileTag = filesTags.FirstOrDefault();
var filteredTagFiles = fileTag?.Tags?.Select(el => el.Id).ToList() ?? new List<int> { 1111 };

var fileWithNullTags = new File { Id = 3, Code = "3", Name = "File 3", Tags = null };
if (fileWithNullTags.Tags != null)
{
	foreach (var file in fileWithNullTags.Tags)
	{
		//Console.WriteLine(file.Id);
	}
}

var listOfNumbers = new List<int>() { 1, 2, 3, 4, 5 };
var emptyListOfNumbers = new List<int>();

// merge dictionary
var dict1 = new Dictionary<string, string>() { { "en", "dict 1 t1 en" }, { "bg", "dict 1 t2 bg" } };
var dict2 = new Dictionary<string, string>() { { "en", "dict 22 t1 en" }, { "bg", "dict 22 t2 bg" } };
var listDict = new List<Dictionary<string, string>>() { dict1, dict2 };
var mergedDict = new Dictionary<string, string>();

var res = listDict.SelectMany(dict => dict).ToLookup(dict => dict.Key, dict => dict.Value);//.ToDictionary(group => group.Key, group => group.First());

foreach (var group in res)
{
	//Console.WriteLine(group.Key);
	foreach (var item in group)
	{
		//Console.WriteLine(item);
	}
}

var emptyList1 = new List<string>();
var emptyList2 = new List<string>();
List<string> nullList = null;
var notEmptyList = new List<List<string>>() { emptyList1, emptyList2, nullList };
//var eresu = notEmptyList.SelectMany(notEmptyList => notEmptyList).ToList();

var listCtor = new List<int>() { 1, 2, 3 };
var listCtor2 = new List<int>(listCtor) { 4, 5 };
var nestedListBase = new List<List<int>>() { listCtor };
//var nestedList = new List<List<int>>(nestedListBase) { new List<int> { 8 } };// or
var nestedList = new List<List<int>>();
nestedList.Add(new List<int>(listCtor) { 8 });
nestedList.Add(new List<int>(listCtor) { 9 });

var nestedListCtor = new List<List<int>>() { listCtor };//count 1
var nestedListCtor2 = new List<List<int>>(nestedListCtor) { listCtor2 };// count 2
var nestedListCtor3 = new List<List<int>>(nestedListCtor) { { listCtor2 } };// count 1 with nested list count 2

var list1 = new List<string>() { "test1", "test2" };
var list2 = new List<string>() { "file1", "file2" };

var list3 = list1.Select((l, idx) => new { l, idx });

//var ttty = list3.GroupBy(x => x.idx);
//var d = tttt.ToDictionary(g => g.Key, g => g.Select(x => new { t1 = x.l, t2 = list2.ElementAt(x.idx) }));

//var elements = list1.Zip(list2, (first, second) => );

IEnumerable<string> keys = new List<string>() { "A", "B", "C", "A", "B", "C", "D" };
IEnumerable<string> values = new List<string>() { "Val A", "Val B", "Val C", "Val A", "Val B", "Val C", "Val D" };

var groupBy = values.GroupBy(x => "Val B", x => "Val C");

var filesFromDb = new List<File>() {
	new File { Id=1,Name = "File 1"},
	new File { Id=2,Name = "File 2"}
};

var newFiles = new List<File>() {
	new File { Id=1,Name = "File 1"},
	new File { Id=3,Name = "File 3"},
};

var deletedFiles = filesFromDb.Where(fd => newFiles.All(nf => nf.Id != fd.Id));
var createdFiles = newFiles.Where(fd => filesFromDb.All(nf => nf.Id != fd.Id));

List<string> originalList = new List<string>();

ListRefTest(originalList);

//originalList.ForEach(l => Console.WriteLine(l));
//https://stackoverflow.com/questions/8708632/passing-objects-by-reference-or-value-in-c-sharp

void ListRefTest(List<string> list)
{
	var localList = new List<string>();
	localList.Add("localList value");
	list = localList;
	//list = localList.Select(l => l).ToList();
	//list.Add("A");

}


char[] ch = new char[] { 'a', 'b' };
string resStr = string.Join("", ch);


var files = new List<File>() {
	new File { Id=1,Code="1", Name = "File 1"},
	new File { Id=2,Code="1", Name = "File 2"},
	new File { Id=3,Code="1", Name = "File 3"},
	new File { Id=4,Code="2", Name = "File 4"},
};
var groupedFiles = files.GroupBy(f => f.Code);

Console.WriteLine();


var glass = new Glass();

if (glass?.Cup?.SmallCup?.isCup != false)
{
	//Console.WriteLine("Is Cup");
}
else
{
	Console.WriteLine("Is no Cup");
}


var glassOfWater = new Glass();
glassOfWater.Bottle ??= new Bottle("customName");
var cupOfWater = new Cup();
cupOfWater.Bottle ??= new Bottle("cupOfWaterBottle");
Console.WriteLine();
class Glass
{
	public Cup Cup { get; set; } = new();
	public Bottle Bottle { get; set; } = new("DefaultName");
}
class Cup
{
	public SmallCup SmallCup { get; set; }
	public Bottle Bottle { get; set; }
}

class SmallCup
{
	public bool isCup { get; set; }
	public string Name { get; set; }
}

class Bottle
{
	public string Name { get; set; }
	public Bottle(string name)
	{
		Name = name;
	}
}


class File
{
	public int Id { get; set; }
	public string Code { get; set; }
	public string Name { get; set; }

	public List<Tag> Tags { get; set; }
}

class Tag
{
	public int Id { get; set; }
	public List<string> Names { get; set; }
}

class Types
{
	// value type
	// point directly to value

	// reference type
	// point to address in memory where is the value

	// mutable
	// value can be changed

	// immutable
	// creates new value when value is changhed

}


