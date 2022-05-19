using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Graph
{
	private int vertices;
	private int edges;
	private LinkedList<int>[] adjList;

	public Graph(int v)
	{
		this.vertices = v;

		adjList = new LinkedList<int>[v];

		for(var i = 0; i < v; i++)
        {
			adjList[i] = new LinkedList<int>();
        }
	}

	public void AddEdge(int currentVertex, int vertexToAdd)
    {
		
		adjList[currentVertex].AddLast(vertexToAdd);

    }

	public void PrintGraph()
    {
        for (int v = 0; v < vertices; v++)
        {
			Console.Write("V " + v );
			for (int e = 0; e < adjList[v].Count; e++)
            {
				Console.Write( " -> " + adjList[v].ElementAt(e));
            }
            Console.WriteLine();
        }
    }

}
