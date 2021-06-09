using System.Collections.Generic;

namespace DijkstrasAlgorithm
{
    public class Graph
    {
        public int Id { get; set; }
        public bool IsStart { get; set; }
        public bool IsFinish { get; set; }
        public int Parent { get; set; }
        public string VertexName { get; set; }
        public int Value { get; set; }
    }
}