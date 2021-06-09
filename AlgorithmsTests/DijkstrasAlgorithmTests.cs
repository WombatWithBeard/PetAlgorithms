using System.Collections.Generic;
using DijkstrasAlgorithm;
using Xunit;

namespace AlgorithmsTest
{
    public class DijkstrasAlgorithmTests
    {
        [Fact]
        public void DijkstrasAlgorithm_ValidSearch()
        {
            var graphs = CreateGraphsList();
            var graphsCost = CreateGraphsCost();
            var graphsParents = CreateGraphsParents();
            var searchResult = new DijkstrasAlgorithmSearch(graphs, graphsCost, graphsParents).SearchRoute();
            
            Assert.NotNull(searchResult._graphsCost);
            Assert.NotNull(searchResult._graphsParents);
            Assert.Equal("C" ,searchResult._graphsParents["Finish"]);
            Assert.Equal("B" ,searchResult._graphsParents["A"]);
            Assert.Equal(6 ,searchResult._graphsCost["Finish"]);
            
        }

        private Dictionary<string, string> CreateGraphsParents()
        {
            var parents = new Dictionary<string, string>
            {
                {"A", "Start"},
                {"B", "Start"},
                {"Finish", ""}
            };
            
            return parents;
        }

        private Dictionary<string, int> CreateGraphsCost()
        {
            var costs = new Dictionary<string, int>
            {
                {"A", 6},
                {"B", 2},
                {"Finish", int.MaxValue}
            };

            return costs;
        }

        private Dictionary<string, Dictionary<string, int>> CreateGraphsList()
        {
            var nodes = new Dictionary<string, Dictionary<string, int>>
            {
                {"Start", new Dictionary<string, int>
                {
                    {"A", 6},
                    {"B", 2}
                }},
                {"A", new Dictionary<string, int>
                {
                    {"Finish", 1}
                }},
                {"B", new Dictionary<string, int>
                {
                    {"A", 3},
                    {"C", 1},
                    {"Finish", 7}
                }},
                {"C", new Dictionary<string, int>
                {
                    {"Finish", 3}
                }},
                {"Finish", new Dictionary<string, int>()}
            };

            return nodes;
        }
    }
}