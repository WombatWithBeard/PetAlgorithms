using System.Collections.Generic;

namespace DijkstrasAlgorithm
{
    public class Graph
    {
        public string RouteNumber { get; set; }
        public int Value { get; set; }
        public List<Graph> NeighborsGraphs { get; set; }
    }
}