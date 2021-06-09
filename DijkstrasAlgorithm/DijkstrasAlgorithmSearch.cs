using System;
using System.Collections;
using System.Collections.Generic;

namespace DijkstrasAlgorithm
{
    public class DijkstrasAlgorithmSearch
    {
        private readonly Dictionary<string, Dictionary<string, int>> _graphs;
        private readonly Dictionary<string, int> _graphsCost;
        private readonly Dictionary<string, string> _graphsParents;
        private readonly Hashtable _checkedNodes;

        public DijkstrasAlgorithmSearch(Dictionary<string, Dictionary<string, int>> graphs, Dictionary<string, int> graphsCost, Dictionary<string, string> graphsParents)
        {
            _graphs = graphs;
            _graphsCost = graphsCost;
            _graphsParents = graphsParents;
            _checkedNodes = new Hashtable();
        }

        public (Dictionary<string, int> _graphsCost, Dictionary<string, string> _graphsParents) SearchRoute()
        {
            var node = FindLowestCostNode(_graphsCost);

            while (!string.IsNullOrEmpty(node))
            {
                var cost = _graphsCost[node];
                var neighbors = _graphs[node];
                foreach (var (key, value) in neighbors)
                {
                    var newCost = cost + value;
                    if (_graphsCost.ContainsKey(key))
                    {
                        if (_graphsCost[key] > newCost)
                        {
                            _graphsCost[key] = newCost;
                            _graphsParents[key] = node;
                        }
                    }
                    else
                    {
                        _graphsCost.Add(key, newCost);
                        _graphsParents.Add(key, node);
                    }
                }
                _checkedNodes.Add(node, null);
                node = FindLowestCostNode(_graphsCost);
            }

            return (_graphsCost, _graphsParents);
        }

        private string FindLowestCostNode(Dictionary<string, int> nodes)
        {
            var lowestCost = int.MaxValue;
            var lowestCostNode = String.Empty;
            
            foreach (var graph in nodes)
            {
                var cost = graph.Value;
                if (cost < lowestCost && !_checkedNodes.Contains(graph.Key))
                {
                    lowestCost = cost;
                    lowestCostNode = graph.Key;
                }
            }

            return lowestCostNode;
        }
    }
}