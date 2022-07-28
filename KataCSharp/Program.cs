
using KataCSharp.LeetCode.B;
using KataCSharp.Recursion;

MyMainRec main = new MyMainRec();
main.MyMain();

var list1 = new List<string>() {"test1", "test2" };
var list2 = new List<string>() {"file1", "file2" };

var list3 = list1.Select((l,idx) => new {l,idx});

var t = list3.GroupBy(x => x.idx);
var d = t.ToDictionary(g => g.Key, g => g.Select(x => new { t1 = x.l, t2 = list2.ElementAt(x.idx) } ));

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

originalList.ForEach(l => Console.WriteLine(l));

void ListRefTest(List<string> list)
{
    var localList = new List<string>();

    localList.Add("localList value");
    list = localList.Select(l => l).ToList();
    //list.Add("A");
   
}


char[] ch = new char[] { 'a', 'b' };
string resStr = string.Join("",ch);




Console.WriteLine();

class File
{
    public int Id { get; set; }
    public string Name { get; set; }
}
