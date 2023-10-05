using static KataCSharp.Common.CommonObjects;

namespace KataCSharp.Sandbox
{
    public class SearchInQueriable
    {

        public void Start()
        {
            var companies = CreateCompanies().AsQueryable();
            var name = "Misho";
            var employee = companies.Where(c => c.Employees.Select(e => e.Name).Contains(name));
            var res = employee.ToList();

        }
    }
}
