using System;

namespace Algorithm {

    public class Pair {

        public Person OldestPerson { get; set; }
        public Person YoungestPerson { get; set; }
        public TimeSpan BirthDateDistance { get; set; }

        public Pair() {
        }

        public Pair(Person person1, Person person2) {
            OldestPerson = Oldest(person1, person2);
            YoungestPerson = Youngest(person1, person2);
            BirthDateDistance = YoungestPerson.BirthDate - OldestPerson.BirthDate;
        }

        private static Person Oldest(Person person1, Person person2) {
            return person1.BirthDate < person2.BirthDate ? person1 : person2;
        }

        private static Person Youngest(Person person1, Person person2) {
            return person1.BirthDate > person2.BirthDate ? person1 : person2;
        }

    }

}