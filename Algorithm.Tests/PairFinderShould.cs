using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithm.Tests {

    public class PairFinderShould {

        private readonly Person _sue = new Person {
            Name = "Sue",
            BirthDate = new DateTime(1950, 1, 1)
        };

        private readonly Person _greg = new Person {
            Name = "Greg",
            BirthDate = new DateTime(1952, 6, 1)
        };

        private readonly Person _mike = new Person {
            Name = "Mike",
            BirthDate = new DateTime(1979, 1, 1)
        };

        private readonly Person _sarah = new Person {
            Name = "Sarah",
            BirthDate = new DateTime(1982, 1, 1)
        };

        [Fact]
        public void Return_An_Empty_Pair_When_Given_An_Empty_List() {
            var persons = new List<Person>();
            var finder = new PairFinder(persons);

            var result = finder.FindPair(Filter.ClosestAge);

            Assert.Null(result.OldestPerson);
            Assert.Null(result.YoungestPerson);
        }

        [Fact]
        public void Return_An_Empty_Pair_When_Given_One_Person() {
            var persons = new List<Person>() {_sue};
            var finder = new PairFinder(persons);

            var result = finder.FindPair(Filter.ClosestAge);

            Assert.Null(result.OldestPerson);
            Assert.Null(result.YoungestPerson);
        }

        [Fact]
        public void Returns_The_Closest_Age_Pair_For_Two_People_List() {
            var persons = new List<Person>() {_sue, _greg};
            var finder = new PairFinder(persons);

            var result = finder.FindPair(Filter.ClosestAge);

            Assert.Same(_sue, result.OldestPerson);
            Assert.Same(_greg, result.YoungestPerson);
        }

        [Fact]
        public void Returns_The_Furthest_Age_Pair_For_Two_People_List() {
            var persons = new List<Person>() {_greg, _mike};
            var finder = new PairFinder(persons);

            var result = finder.FindPair(Filter.FurthestAge);

            Assert.Same(_greg, result.OldestPerson);
            Assert.Same(_mike, result.YoungestPerson);
        }

        [Fact]
        public void Returns_The_Furthest_Age_Pair_For_Four_People_List() {
            var persons = new List<Person>() {_greg, _mike, _sarah, _sue};
            var finder = new PairFinder(persons);

            var result = finder.FindPair(Filter.FurthestAge);

            Assert.Same(_sue, result.OldestPerson);
            Assert.Same(_sarah, result.YoungestPerson);
        }

        [Fact]
        public void Returns_The_Closest_Age_Pair_For_Four_People_List() {
            var persons = new List<Person>() {_greg, _mike, _sarah, _sue};
            var finder = new PairFinder(persons);

            var result = finder.FindPair(Filter.ClosestAge);

            Assert.Same(_sue, result.OldestPerson);
            Assert.Same(_greg, result.YoungestPerson);
        }

    }

}