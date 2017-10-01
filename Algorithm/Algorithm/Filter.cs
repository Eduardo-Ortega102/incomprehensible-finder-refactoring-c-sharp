using System.Collections.Generic;
using System.Linq;

namespace Algorithm {

    public abstract class Filter {

        public static readonly Filter ClosestAge = new ClosestAge();
        public static readonly Filter FurthestAge = new FurthestAge();

        public Pair Apply(List<Pair> pairs) {
            var pairToReturn = pairs.First();
            foreach (var pair in pairs)
                if (MatchCondition(pair, pairToReturn)) pairToReturn = pair;
            return pairToReturn;
        }

        protected abstract bool MatchCondition(Pair pair1, Pair pair2);

    }

    internal class ClosestAge : Filter {

        protected override bool MatchCondition(Pair pair1, Pair pair2) {
            return pair1.BirthDateDistance < pair2.BirthDateDistance;
        }

    }

    internal class FurthestAge : Filter {

        protected override bool MatchCondition(Pair pair1, Pair pair2) {
            return pair1.BirthDateDistance > pair2.BirthDateDistance;
        }

    }

}