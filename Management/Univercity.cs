using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    abstract class Univercity
    {
        public static int LastID = 1;
        public string NameStruct { get; set; }
        private int id_stract;
        public Univercity(string name)
        {
            NameStruct = name;
            id_stract = LastID++;
        }

        public int ID_Struct
        {
            get
            {
                return id_stract;
            }
        }
    }
}
