using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class WorkerFacylty
    {
        public List<Facylty> facylties = null;
        private WorkerFacylty()
        {
            facylties = Facylty.GetFacylties();
        }

        private static WorkerFacylty instence;

        public static WorkerFacylty GetInstance()
        {
            return instence ?? (instence = new WorkerFacylty());
        }

        public void Add(string name_facylty)
        {
            facylties.Add(new Facylty(name_facylty));
        }

        public void Delete(int id_for_delete)
        {
            for (int i = 0; i < facylties.Count; i++)
            {
                if(id_for_delete == facylties[i].ID_Struct)
                {
                    facylties.Remove(facylties[i]);
                    return;
                }
            }
        }

        public void Update(int id_facylty,string name)
        {
            for (int i = 0; i < facylties.Count; i++)
            {
                if(facylties[i].ID_Struct == id_facylty)
                {
                    facylties[i].NameStruct = name;
                    return;
                }
            }
        }
    }
}
