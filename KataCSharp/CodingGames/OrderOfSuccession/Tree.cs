using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsSoftuni.CodingGames.OrderOfSuccession
{
    class Tree
    {

        public void Dfs(List<Node> children)
        {
              
            foreach (var child in children.OrderByDescending(el => el.Name).ThenBy(el => el.Birth))
            {
                Console.WriteLine(child.Name);
                Dfs(child.Children);
            }

        }
    }

    class Node
    {
        public string Name { get; set; }
        public string Parent { get; set; }
        public int Birth { get; set; }
        public string Death { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }

        public List<Node> Children = new List<Node>();

    }


}
