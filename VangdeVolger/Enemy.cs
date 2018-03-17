using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VangdeVolger
{
    class Enemy : Movable
    {
        // ALL THE NODES - need to fill this with the nodes to check (so every GameField containing null).
        Dictionary<GameField, Dictionary<GameField, int>> vertices = new Dictionary<GameField, Dictionary<GameField, int>>();

        // Add a node to the 'maze'.
        private void AddNode(GameField name, Dictionary<GameField, int> edges)
        {
            vertices[name] = edges;
        }

        // Find the shortest path from start to finish.
        private List<GameField> ShortestPath(GameField start, GameField finish)
        {
            var previous = new Dictionary<GameField, GameField>();
            var distances = new Dictionary<GameField, int>();
            var nodes = new List<GameField>();

            List<GameField> path = null;
            
            // For every node set the tentative distance and add them to the node list.
            foreach(var vertex in vertices)
            {
                if (vertex.Key == start)
                    distances[vertex.Key] = 0;
                else
                    distances[vertex.Key] = int.MaxValue;

                nodes.Add(vertex.Key);
            }

            // For as long as there are nodes to check.
            while (nodes.Count != 0)
            {
                // Sort the nodes from shortest to longest distance.
                nodes.Sort((x, y) => distances[x] - distances[y]);

                // Remove the smallest node.
                var smallest = nodes[0];
                nodes.Remove(smallest);
                
                // If the current node is equal to finish, trace back our steps and set the path.
                if (smallest == finish)
                {
                    path = new List<GameField>();
                    while(previous.ContainsKey(smallest))
                    {
                        path.Add(smallest);
                        smallest = previous[smallest];
                    }

                    break;
                }
                
                // if the distance of the smallest node is infinity then stop looking.
                if (distances[smallest] == int.MaxValue)
                    break;

                // Calculate the distance of nodes.
                foreach (var neighbor in vertices[smallest])
                {
                    var alt = distances[smallest] + neighbor.Value;
                    if (alt < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = alt;
                        previous[neighbor.Key] = smallest;
                    }
                }
            }

            return path;
        }

        void Decide()
        {
            // AddNodes()
            // FindPath()
        }

        public Enemy()
        {
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Enemy.png");
        }
    }
}
