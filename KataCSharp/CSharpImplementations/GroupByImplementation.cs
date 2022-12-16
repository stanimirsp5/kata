using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.CSharpImplementations
{
    public class GroupByImplementation
    {
        public void Start()
        {
            GroupEmployeesByCompany();
        }

        void GroupEmployeesByCompany()
        {
            var employees = CommonObjects.CreateEmployees();

            var groupedEmployees = employees.GroupBy(em => em.Position);

            var groupedEmployeesQuery = from employee in employees
                                        group employee by employee.Position;
        }

    }
}
