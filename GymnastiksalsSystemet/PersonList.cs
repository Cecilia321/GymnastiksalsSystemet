using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastiksalsSystemet
{
    internal class PersonList
    {
        private List<Person> personlist = new List<Person>();

        internal List<Person> Personlist { get => personlist; set => personlist = value; }

        public string PrintList()
        {
            string pl = "";
            foreach (Person person in personlist)
            {
                pl = pl + person.ToString();
            }
            return pl;
        }

        public void AddPerson(int id, string name, int age)
        {
            Person p = new Person(name, age, id);
            personlist.Add(p);
        }
    }
}
