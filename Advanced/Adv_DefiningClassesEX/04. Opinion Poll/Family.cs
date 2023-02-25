
namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;
        public Family()
        {
            this.people = new List<Person>();
        }
        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            int biggestAge = 0;
            Person oldestPerson = new();
            foreach (var person in this.people)
            {
                if (person.Age > biggestAge)
                {
                    biggestAge = person.Age;
                    oldestPerson = person;
                }
            }
            return oldestPerson;
        }

        public List<Person> GetPeopleOlderThan30()
        {
            return this.people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        }
    }
}

