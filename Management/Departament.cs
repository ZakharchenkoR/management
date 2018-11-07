using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class Departament: Univercity
    {
        public int ID_Fakylty { get; set; }
        public Departament(string departament,int id_facylty):base(departament)
        {
            NameStruct = departament;
            ID_Fakylty = id_facylty;
        }

        public static List<Departament> GetDepartaments()
        {
            return new List<Departament>
            {
                new Departament("Розробка ПО",1),
                new Departament("Aдминистрирования",1)
            };
        }
    }
}
