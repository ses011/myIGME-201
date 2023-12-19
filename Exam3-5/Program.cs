using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Node> nodes = SetNodes();

            List<Node> dijkstra = Dijkstra(nodes, nodes[0]);
            
            foreach (Node node in dijkstra)
            {
                Console.WriteLine(node.name);
            }
        }

        // Hard code the Node/Edge values and directions
        // Display adjacency list and matrix
        public static List<Node> SetNodes()
        {
            List<Node> nodes = new List<Node>();
            Node red = new Node("red");
            Node blue = new Node("blue");
            Node gray = new Node("gray");
            Node lBlue = new Node("lBlue");
            Node yellow = new Node("yellow");
            Node purple = new Node("purple");
            Node green = new Node("green");
            Node orange = new Node("orange");

            nodes.Add(red);
            nodes.Add(blue);
            nodes.Add(gray);
            nodes.Add(lBlue);
            nodes.Add(yellow);
            nodes.Add(purple);
            nodes.Add(green);
            nodes.Add(orange);

            red.edges.Add(new Edge(1, blue));
            red.edges.Add(new Edge(5, gray));
            gray.edges.Add(new Edge(1, orange));
            gray.edges.Add(new Edge(0, lBlue));
            blue.edges.Add(new Edge(1, lBlue));
            blue.edges.Add(new Edge(8, yellow));
            lBlue.edges.Add(new Edge(0, gray));
            lBlue.edges.Add(new Edge(1, blue));
            orange.edges.Add(new Edge(1, purple));
            purple.edges.Add(new Edge(1, yellow));
            yellow.edges.Add(new Edge(6, green));


            Console.WriteLine("Adjacency List");
            foreach (Node node in nodes)
            {
                Console.Write($"\n{node.name}: ");
                foreach (Edge edge in node.edges)
                {
                    Console.Write(edge.end.name + " ");
                }
            }

            int[,] matrix = new int[nodes.Count, nodes.Count];
            // Check every position against all other positions to check adjacency and get distance if so
            // Add all values to matrix
            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (j == i)
                    {
                        matrix[i, j] = -2;
                    }
                    else
                    {
                        if (nodes[j].edges.Count == 0)
                        {
                            matrix[i, j] = -1;
                            break;
                        }

                        foreach (Edge edge in nodes[j].edges)
                        {
                            if (nodes[i].name.Equals(edge.end.name))
                            {
                                matrix[i, j] = edge.val;
                                break;
                            }
                            else
                            {
                                matrix[i, j] = -1;
                            }
                        }
                    }
                }
            }

            // Display Matrix
            Console.WriteLine("\nAdjacency Matrix: -1 = no connection\t-2 = same node");

            string label = "R  B  G  L  Y  P  G  O";
            Console.Write("\n " + label);
            for (int i = 0; i < nodes.Count; i++)
            {
                Console.Write($"\n{label.Substring((i * 3), 1)}");
                for (int j = 0; j < nodes.Count; j++)
                {
                    Console.Write($" {matrix[i, j]}");
                }
            }
            Console.WriteLine();

            return nodes;
        }



        /*
         * Depth first search algorithm


        public List<string> DFS()
        {

        }
*/

        /* Dijkstra's shortest path algorithm - recursively finds cheapest path
        */
        public static List<Node> Dijkstra(List<Node> nodes, Node root)
        {
            List<Node> list = new List<Node>();
            Console.WriteLine("\n\nDijkstra's");
            while (nodes.Count > 0)
            {
                // Checks that nodes list contains edge end point (neighbor)
                foreach (Edge edge in root.edges)
                {
                    if (nodes.Contains(edge.end) && edge.val < edge.end.distance)
                    {
                        if (edge.end.distance == int.MaxValue)
                        {
                            edge.end.distance = edge.val;
                        }
                        else
                        {
                            edge.end.distance += edge.val;
                        }
                    }
                }
                nodes.Remove(root);
                root.finished = true;
                list.Add(root);

                root = null;
                foreach (Node node in nodes)
                {
                    if (root == null || node.distance < root.distance)
                    {
                        root = node;
                    }
                }
            }
            return list;
        }

        // Node class, has color string and list of Edges leaving it
        public class Node
        {
            public string name;
            public List<Edge> edges = new List<Edge>();

            //For Dijkstra's
            public Boolean finished = false;
            public int distance = int.MaxValue;

            public Node(string name)
            {
                this.name = name;
            }
        }

        // Edge class, has edge length (for dijkstra's) and the node it's pointing to
        public class Edge
        {
            public int val;
            public Node end;


            public Edge(int val, Node end)
            {
                this.val = val;
                this.end = end;
            }
        }
    }
}
