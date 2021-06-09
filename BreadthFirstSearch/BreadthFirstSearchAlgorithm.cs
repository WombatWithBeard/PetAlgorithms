using System;
using System.Collections;
using System.Collections.Generic;

namespace BreadthFirstSearch
{
    //O(V + E)
    public class BreadthFirstSearchAlgorithm
    {
        private readonly Queue<Person> _searchQueue;
        private readonly Hashtable _checkedPersons;

        public BreadthFirstSearchAlgorithm()
        {
            _checkedPersons = new Hashtable();
            _searchQueue = new Queue<Person>();
        }

        public string SearchRobot(Person person)
        {
            _searchQueue.Enqueue(person);

            while (_searchQueue.Count > 0)
            {
                var man = _searchQueue.Dequeue();
                if (_checkedPersons.Contains(man)) continue;
                if (man.IsRobot)
                {
                    Console.WriteLine(man.Name + " is robot");
                    return man.Name;
                }

                Console.WriteLine(man.Name + " is not robot");
                _checkedPersons.Add(man.Name, man);
                if (man.Friends == null) continue;
                foreach (var manFriend in man.Friends) _searchQueue.Enqueue(manFriend);
            }

            return null;
        }
    }
}