using AlgorithmsSoftuni.CodingGames.OrderOfSuccession;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
//using Xunit;

namespace KataCSharp.CSharpImplementations.SelectMany
{
    //https://codeblog.jonskeet.uk/2010/12/27/reimplementing-linq-to-objects-part-9-selectmany/
    // LINQ implementations https://dotnetcorecentral.com/blog/linq-internals/
    //yield in one sentence - yield holds the state of an enumeration
    public class SelectManyImplementation
    {
        public void Start()
        {
            // FlattenWithProjectionAndIndex();

            //CallSelect();
            Queries.Run();
        }
        public delegate string PrintString(string s);
        void AccDel(PrintString ps1)
        {
            ps1("test");
        }
        string Func2(string str)
        {
            var r = str + "1";
            return r;
        }
        string GetName(Func<string,string> func)
        {


            return "";
        }

        // [Fact]
        public static void FlattenWithProjectionAndIndex()
        {
            int[] numbers = { 3, 5, 20, 15 };
            var query = numbers.SelectMany((x, index) => (x + index).ToString().ToCharArray(),
                                           (x, c) => x + ": " + c);
            
            var query2 = numbers.SelectMany((x, index) => (index).ToString());
            // 3 => "3: 3"
            // 5 => "5: 6"
            // 20 => "20: 2", "20: 2"
            // 15 => "15: 1", "15: 8"
            //query.SequenceEqual(new List<string> { "3: 3", "5: 6", "20: 2", "20: 2", "15: 1", "15: 8" });
            //var t =SelectManyImpl(numbers, (x) => x);
            Func<string, string> selector = str => str.ToUpper();
            var str = selector("test");


            List<int> list= new List<int> { 3, 5, 20, 15 };
            //var r = list.Select(l => l);
            //var tt = SelectImpl(list, el => el + "t");
            //tt.ToList();
            // YieldTest(5);
            Console.WriteLine("test2");

        }

        static void CallSelect()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            Func<int, bool> selector = n => n > 1;
            Func<IEnumerable<int>, IEnumerable<int>> selector2 = list => list;
            
           // var res = SelectImpl(list, selector2);

        }

        private static IEnumerable<TResult> SelectImpl<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {

            foreach (TSource item in source)
            {
                foreach (TResult result in selector(item))
                {
                    yield return result;
                }
            }

           // var t = selector(source.First());    
            //return t;
        }


        static void CallYield()
        {
            var numbers = YieldTest(5);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        static IEnumerable<int> YieldTest(int num)
        {
            for (int i = 0; i < num; i++)
            {
                yield return i;
            }
        }


        //private IEnumerable<TResult> SelectManyImpl<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        //{
        //    Console.WriteLine("test");
        //    foreach (TSource item in source)
        //    {
        //        foreach (TResult result in selector(item))
        //        {
        //            yield return result;
        //        }
        //    }
        //}

        //private IEnumerable<TResult> SelectManyImpl2<TSource, TResult>(
        //    IEnumerable<TSource> source,
        //    Func<TSource, IEnumerable<TResult>> selector)
        //{
        //    foreach (TSource item in source)
        //    {
        //        foreach (TResult result in selector(item))
        //        {
        //            yield return result;
        //        }
        //    }
        //}

        public delegate int Del1(int a, int b);
        public int SumNumders(int a, int b)
        {
            return a + b;
        }

        public void DelMethod()
        {
            //1
            var sum = new Del1(SumNumders);
            var rsum = sum(1, 2);

                //1.2
                Del1 sum12 = SumNumders;
                var rsum12 = sum12(1, 2);

            //2
            Del1 sum2 = (a,b) => a + b;
            var rsum2 = sum2(1, 2);

            //3
            var sum3 = delegate (int a, int b)
            {
                return a + b;
            };
            var rsum3 = sum3(1, 2);

            //4
            Del1 sum4 = (a, b) =>
            {
                return a + b;
            };
        }

        delegate bool BoolDelegate(int num);
        delegate int IntDelegate(int num);
        bool ExDel(int num)
        {
            return num > 5;
        }

        void RunDel()
        {
            var predicate = new BoolDelegate(ExDel);

            BoolDelegate pr = el => el > 5;
            var pr2 = new BoolDelegate(el => el > 5);

            var t = pr(6);

            IntDelegate intDelegate = el => el + 5;
            var intRes = intDelegate(5);



        }

    }

    class IntObj
    {
        private string? _str;

        public int Num { get; set; }
        public string? NumStr { get; set; }
        //{
        //    get => _str;
        //    set => _str = value + "";
        //}
    }
    class Company
    {
        public string CompanyName { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
    class Employee
    {
        public string Name { get; set; }
        public IEnumerable<Phone> Phones{ get; set; }
    }
    class Phone
    {
        public string Number { get; set; }
    }

    class Name
    {
        public string CompanyName { get; set; }
        public string EmployeeName { get; set; }
    }

    public static class Queries
    {
        static List<Employee> CreateEmployees()
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
        static List<Company> CreateCompanies()
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

        delegate IEnumerable<Phone> CollDel(Employee employee);
        delegate T CompAndEmpDel<T>(Company company, Employee employee);
        delegate IEnumerable<T> CompAndEmpDelCol<T>(Company company, Employee employee);
        //delegate T CompAndEmpDel(Company company,Employee employee);

        static void GetPhoneFromEmployee()
        {
            Employee emp11 = new Employee()
            {
                Name = "Misho",
                Phones = new List<Phone>() { new Phone { Number = "088 1234567" }, new Phone { Number = "0000000000" } }
            };
            CollDel del = em => em.Phones;
            var t = del(emp11);
            Func<Employee, IEnumerable<Phone>> func = emp => emp.Phones;

            CompAndEmpDel<Name> compAndEmp = (comp, emp) => new Name { CompanyName = comp.CompanyName, EmployeeName = emp.Name };
            CompAndEmpDel<object> compAndEmp2 = (comp, emp) => new { comp.CompanyName, emp.Name };
            //CompAndEmpDelCol<IEnumerable <object>> compAndEmp3 = (comp, emp) => new { comp.CompanyName, emp.Name };
            var compAndEmp3 = new CompAndEmpDelCol<object>(GetNames);
        }

        public static void Run()
        {
            var employees = CreateEmployees();
            var companies = CreateCompanies();
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var listStr = new List<List<string>> { new List<string> { "abc","def","ghij" }, new List<string> { "Test 1", "Test 2" } };
            list.Where(el => el > 5);//.ToList().ForEach(el => Console.Write(el + " "));
            //list.MyWhere(el => el > 5).ToList().ForEach(el => Console.Write(el + " "));
            //listStr.MyWhere(el => el == "c").ToList().ForEach(el => Console.Write(el + " "));

            //var t = list.Select(el => el + 5);//.ToList().ForEach(el => Console.Write(el + " "));

            //var t2 = list.MySelect(el => el + 5 + "" ).ToList();
            //var intObjRes = list.MySelect(el => new IntObj { Num = el, NumStr = el + ""} ).ToList();
            var list2d = new List<List<int>> { new List<int> { 1, 2, 3, 4, 5, 6, 7 } };
            var list1d = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            var listToString = list2d.Select(el => el + "");
            var tt = list2d.Select(el => el.Select(e => e + ""));
            foreach (var items in tt)
            {
                foreach (var subItem in items)
                {
                    Console.WriteLine(subItem);
                }
            }

            var resListStr = employees.Select((el,i) => i + ": "+el.Name);
            var empPhones = employees.SelectMany(el => el.Phones);
            var myEmpPhones = employees.MySelectMany(el => el.Phones).ToList();
            var empPhonesByCompany = employees.SelectMany(emp => emp.Phones, (emp, phone) => new { emp.Name, phone.Number});
            var companyNameAndEmp = companies.SelectMany(cmp => cmp.Employees, (cmp, emp) => new { cmp.CompanyName, emp.Name });

            var myEmpPhonesByCompany = employees.MySelectMany<object, Employee, Phone>(emp => emp.Phones, (emp, phone) => new { emp.Name, phone.Number });
            
            
            var myEmpPhonesByCompanyWithIndex = employees.MySelectMany(emp => emp.Phones, (emp, phone) => new { emp.Name, phone.Number });

            //var myCompPhones = companies.SelectMany(comp => comp.CompanyName, (comp, emp) => new { comp.Employees });
            var genericNames = new GenericNames<Company>();
            genericNames.GetNames(employees.First());


            //if (employees is Enumerable.It Iterator<Employee> iterator)
            //{
            //    return iterator.Where(predicate);
            //}

        }

        class GenericNames<T>
        {
            // CS0693
            public void GetNames(T names) {
                Console.WriteLine();
            }
            public void GetNames<U>(U names)
            {

                Console.WriteLine();
            }
        }

        public static IEnumerable<TResult> MySelectMany<TResult, TSource, TSourceInner>(this IEnumerable<TSource> source,
            Func<TSource, IEnumerable<TSourceInner>> collectionSelector,
            Func<TSource, TSourceInner, TResult> resultSelector)
        {

            foreach (var firstItem in source)
            {
                var phones = collectionSelector(firstItem);
                foreach (var secondItem in collectionSelector(firstItem))
                {
                    yield return resultSelector(firstItem,secondItem);
                }
            }

        }

        static IEnumerable<object> GetNames(Company comp, Employee emp)
        {
            yield return new { comp.CompanyName, emp.Name };
        }

        public static IEnumerable<TResult> MySelectMany<TResult, TSource>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> func)
        {
            foreach (var obj in source)
            {
                foreach (var objItem in func(obj))
                {
                    yield return objItem;
                }
            }
        }

        public static IEnumerable<T> MyWhere<T> (this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<TResult> MySelect<TSource,TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> predicate)
        {

            foreach(var item in source)
            {
                var t = predicate(item);
                yield return t;
            }
        }
    }
}
