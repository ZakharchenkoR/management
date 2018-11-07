using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class Professor:Person,IComparable
    {
        public Professor(string name,int age,int id_departament):base(name,age,id_departament)
        {
            Name = name;
            Age = age;
            ID_Departament = id_departament;
        }

        public static List<Professor> GetProfessors()
        {
            return new List<Professor>
            {
                new Professor("Ivan Ivanovich",39,1),
                new Professor("Stanislav Vasilevich",45,2),
                new Professor("Petr Georgiyovich",55,1),
                new Professor("Alexander Dmitrovich",35,2),
            };
        }

        public int CompareTo(object obj)
        {
            Professor professor = obj as Professor;
            if (professor != null)
                return this.Name.CompareTo(professor.Name);
            else
                throw new Exception("This sort is not true!");
        }
    }
}
