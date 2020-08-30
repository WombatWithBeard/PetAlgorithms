using BreadthFirstSearch;
using Xunit;

namespace AlgorithmsTest
{
    public class BreadthFirstSearchTests
    {
        [Fact]
        public void BinarySearch_ValidItem()
        {
            var person = CreatePerson();
            var search = new BreadthFirstSearchAlgorithm();

            var result = search.SearchRobot(person);

            Assert.NotNull(result);
            Assert.Equal("Robot", result);
        }

        private Person CreatePerson() =>
            new Person
            {
                Name = "One One",
                IsRobot = false,
                Friends = new[]
                {
                    new Person
                    {
                        Name = "Second One",
                        IsRobot = false,
                        Friends = new[]
                        {
                            new Person
                            {
                                Name = "Third One",
                                IsRobot = false,
                                Friends = null
                            }
                        }
                    },
                    new Person
                    {
                        Name = "Second Two",
                        IsRobot = false,
                        Friends = new[]
                        {
                            new Person
                            {
                                Name = "Third Two",
                                IsRobot = false,
                                Friends = null
                            },
                            new Person
                            {
                                Name = "Third Three",
                                IsRobot = false,
                                Friends = new[]
                                {
                                    new Person
                                    {
                                        Name = "Four One",
                                        IsRobot = false,
                                        Friends = null
                                    },
                                    new Person
                                    {
                                        Name = "Four Two",
                                        IsRobot = false,
                                        Friends = null
                                    }
                                }
                            }
                        }
                    },
                    new Person
                    {
                        Name = "Second Three",
                        IsRobot = false,
                        Friends = new[]
                        {
                            new Person
                            {
                                Name = "Third Four",
                                IsRobot = false,
                                Friends = null
                            },
                            new Person
                            {
                                Name = "Third Five",
                                IsRobot = false,
                                Friends = new[]
                                {
                                    new Person
                                    {
                                        Name = "Robot",
                                        IsRobot = true,
                                        Friends = null
                                    },
                                    new Person
                                    {
                                        Name = "Four Four",
                                        IsRobot = false,
                                        Friends = null
                                    }
                                }
                            }
                        }
                    },
                }
            };
    }
}