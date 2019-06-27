using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            this.familyMembers = new List<Person>();
        }

        public void AddFamilyMember(Person newMember)
        {
            familyMembers.Add(newMember);
        }

        public  Person GetOldestPerson()
        {
            Person oldestPerson = familyMembers.OrderByDescending(p => p.Age).FirstOrDefault();

            return oldestPerson;
        }
    }
}
