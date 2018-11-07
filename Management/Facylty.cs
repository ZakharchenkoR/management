using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class Facylty:Univercity
    {
        public Facylty(string name_facylty):base(name_facylty)
        {
            NameStruct = name_facylty;
        }

        public static List<Facylty> GetFacylties()
        {
            return new List<Facylty>
            {
                new Facylty("Информационные технологии")
            };
        }
    }
}
