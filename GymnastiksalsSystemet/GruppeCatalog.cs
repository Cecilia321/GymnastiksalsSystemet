using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastiksalsSystemet
{
    internal class GruppeCatalog
    {
        private List<Gruppe> gruppelist = new List<Gruppe>();

        internal List<Gruppe> gruppelist1 { get => gruppelist; set => gruppelist = value; }

        public string PrintGruppe()
        {
            string gp = "";
            foreach (Gruppe gruppe in gruppelist)
            {
                gp = gp + gruppe.ToString();
            }
            return gp;
        }

        public void CreateGruppe(string GroupName, int AgeGroup, int Number, int Id)
        {
            Gruppe g = new Gruppe(GroupName, AgeGroup, Number, Id);
            gruppelist.Add(g);
        }

    }

    
}
