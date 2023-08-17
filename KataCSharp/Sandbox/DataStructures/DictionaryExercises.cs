using KataCSharp.CSharpImplementations;

namespace KataCSharp.Sandbox.DataStructures
{
    public class DictionaryExercises
    {
        public void Start()
        {
            ToDictionaryTest();
        }

        public void ToDictionaryTest()
        {
            var groceries = CommonObjects.BuildGroceries();
            var customerGroceries = new List<int> { 3, 4 };

            var groceriesBoughtByCustomerDict = groceries.ToDictionary(g => g.Id);
            var res = groceries.Where(g =>
            {
                //var groceryBoughtByCustomer = customerGroceries.FirstOrDefault(cg => cg == g.Id);
                //if(groceryBoughtByCustomer == 0)
                //    return false;
                if (!groceriesBoughtByCustomerDict.ContainsKey(g.Id))
                     return false;

                return true;
            });
        }
    }
}
