using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymnastiksalsSystemet
{
    internal class Gruppe
    {
        public string GroupName { get; set; }
        public string AgeGroup { get; set; }
        public int Number { get; set; }
        public int Id { get; set; }

        public Gruppe(string GroupName, string AgeGroup, int Number, int Id ) 
        {
            this.GroupName = GroupName;
            this.AgeGroup = AgeGroup;
            this.Number = Number;
            this.Id = Id;
        }

        public override string ToString()
        {
            return "Id: " + Id + "Gruppens navn: " + GroupName + "\n" + "Aldersgruppen" + AgeGroup + "\n" + "Antal elevet: " + Number + "\n";
        }
    }
}
