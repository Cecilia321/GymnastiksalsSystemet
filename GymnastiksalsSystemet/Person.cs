using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymnastiksalsSystemet
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }

        public Person(string Name, int Age, int Id) 
        {
            this.Name = Name;
            this.Age = Age;
            this.Id = Id;
        }

        public override string ToString()
        {
            return "Id: " + Id + "Name: " + Name + "Age: " + Age + "\n";
        }
    }
}
