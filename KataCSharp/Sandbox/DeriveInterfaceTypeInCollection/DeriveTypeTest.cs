using KataCSharp.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Sandbox.DeriveInterfaceTypeInCollection
{
	public class DeriveTypeTest
	{

		public void Start()
		{

			List<Water> bottlesWatter = new List<Water>(){ new Water("Bankq") , new Water("Gorna Banq") };
			List<Liquid> interfaceList = new List<Liquid>(bottlesWatter);
			GetNames(bottlesWatter);
		}

		string GetNames(IEnumerable<Liquid> liquids)
		{
			return string.Join(", ", liquids.Select(l => l.GetName()));
		}

	}

	class Water : Liquid
	{
		public string Name { get; set; }
        public Water(string name)
        {
			Name = name;
        }

        public string GetName()
		{
			return Name;
		}
	}

	interface Liquid
	{
		string GetName();
    }

}
