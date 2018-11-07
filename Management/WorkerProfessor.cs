using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class WorkerProfessor
    {
        public List<Professor> professors = null;
        private WorkerProfessor()
        {
            professors = Professor.GetProfessors();
        }

        private static WorkerProfessor instance;

        public static WorkerProfessor GetInstance()
        {
            return instance ?? (instance = new WorkerProfessor());
        }

        public void Add(string name,int age,int id_departament)
        {
            professors.Add(new Professor(name, age, id_departament));
        }

        public void Delete(int id_for_delete)
        {
            for (int i = 0; i < professors.Count; i++)
            {
                if(id_for_delete == professors[i].ID_Departament)
                {
                    professors.Remove(professors[i]);
                    return;
                }
            }
        }

        public void Update(int id_professor,int id_departament,int age,string name)
        {
            for (int i = 0; i < professors.Count; i++)
            {
                if(professors[i].ID_Person == id_professor)
                {
                    professors[i].ID_Departament = id_departament;
                    professors[i].Name = name;
                    professors[i].Age = age;
                    return;
                }
            }
        }
    }
}
