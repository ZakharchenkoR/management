using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class WorkerDepartament
    {
        public List<Departament> departaments = null;

        private WorkerDepartament()
        {
            departaments = Departament.GetDepartaments();
        }

        private static WorkerDepartament instance;

        public static WorkerDepartament GetInstance()
        {
            return instance ?? (instance = new WorkerDepartament());
        }

        public void Add(string name,int id_facylty)
        {
            departaments.Add(new Departament(name, id_facylty));
        }

        public void Delete(int id_for_delete)
        {
            for (int i = 0; i < departaments.Count; i++)
            {
                if(id_for_delete == departaments[i].ID_Struct)
                {
                    departaments.Remove(departaments[i]);
                }
            }
        }

        public void Update(int id_departament,int id_facylty,string name)
        {
            for (int i = 0; i < departaments.Count; i++)
            {
                if(id_departament == departaments[i].ID_Struct)
                {
                    departaments[i].NameStruct = name;
                    departaments[i].ID_Fakylty = id_facylty;
                    return;
                }
            }
        }

       
    }
}
