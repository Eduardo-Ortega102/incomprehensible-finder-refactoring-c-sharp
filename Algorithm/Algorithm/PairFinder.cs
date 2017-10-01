using System.Collections.Generic;

namespace Algorithm {

    public class PairFinder {

        private readonly List<Person> _persons;

        public PairFinder(List<Person> persons) {
            _persons = persons;
        }

        public Pair FindPair(Filter filter) {
            var pairs = new List<Pair>();
            for (var i = 0; i < _persons.Count - 1; i++)
                for (var j = i + 1; j < _persons.Count; j++)
                    pairs.Add(new Pair(_persons[i], _persons[j]));
            return pairs.Count < 1 ? new Pair() : filter.Apply(pairs);
        }

    }

}