using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgorithmsSoftuni.CodingGames.OrderOfSuccession
{
    class SymbolGraph
    {
        public List<Dictionary<string, List<Heir>>> adjList;

        public SymbolGraph()
        {
            adjList = new List<Dictionary<string, List<Heir>>>();
        }

        public void AddVertex(string parentName)
        {
            // unique parents only
            bool isParentRecorded = adjList.Where(d => d.ContainsKey(parentName)).Any();
            if (isParentRecorded) return;

            adjList.Add(new Dictionary<string, List<Heir>>());

            var dictionary = adjList.Last();
            dictionary.Add(parentName, new List<Heir>());
        }

        public void AddEdge(string parent, Heir heir)
        {

            foreach (var item in adjList)
            {
                if (item.ContainsKey(parent))
                {
                    var parentChilds = item[parent];

                    parentChilds.Add(heir);
                  
                    item[parent] = parentChilds.OrderByDescending(el => el.Gender).ThenBy(el => el.Birth).ToList();
                }
            }
        }

        public List<Dictionary<string, List<Heir>>> GetAdjList()
        {
            return adjList;
        }

        public void PrintGraph()
        {
            foreach (Dictionary<string, List<Heir>> item in adjList)
            {

                foreach (var kvp in item)
                {
                    Console.WriteLine("Parent: {0} ", kvp.Key, kvp.Value);
                    foreach (var heir in kvp.Value)
                    {
                        Console.WriteLine(" - child: {0}", heir.Name);

                    }
                }
            }
        }
    }
    class Heir
    {
        public string Name { get; set; }
        public string Parent { get; set; }
        public int Birth { get; set; }
        public string Death { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }
    }

    class Result
    {
        List<Dictionary<string, List<Heir>>> adjList;
        public void Print(List<Dictionary<string, List<Heir>>> adjList)
        {
            this.adjList = adjList;
            Heir heir = new Heir() { Name = "-" };

            Dfs(heir);
        }

        private void Dfs(Heir heir)
        {

            foreach (var item in adjList)
            {
                if (!item.ContainsKey(heir.Name)) continue;

                var childs = item[heir.Name]; 
                foreach (var child in childs)
                {
                    if (child.Death == "-" && child.Religion == "Anglican")
                    {
                        Console.WriteLine(child.Name);
                    }
                    Dfs(child);
                }
            }
        }
    }
}
