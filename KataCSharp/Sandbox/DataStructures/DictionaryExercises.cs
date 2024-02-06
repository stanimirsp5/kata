using KataCSharp.Common;

namespace KataCSharp.Sandbox.DataStructures
{
    public class DictionaryExercises
    {
        public void Start()
        {
            //ToDictionaryTest();
			ContainsKeyReferenceTest();
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

        void ContainsKeyReferenceTest()
        {
            var event1 = new Event("First event", 12);
            var event2 = new Event("Second event", 55);
            var event3 = new Event("First event", 12);

            var dict = new Dictionary<Event, string>();
            dict.Add(event1, "val1");
            dict.Add(event2, "val2");

            if (dict.ContainsKey(event3))
            {
                Console.WriteLine("no");
            }
            if (dict.ContainsKey(event1))
            {
                Console.WriteLine("yes");
            }
			if (dict.ContainsKey(event2))
			{
				Console.WriteLine("yes");
			}

            try
            {
                dict.Add(event3,"val3");//should add
                dict.Add(event1,"val4");//should throw error because of duplicating keys
            }
            catch (Exception ex)
            {

            }

		}

        class Event
        {
            public string Name { get; set; }
            public int Amount { get; set; }

            public Event(string name, int amount)
            {
                Name = name;
                Amount = amount;
            }
        }
    }
}
