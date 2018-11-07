using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class ChekingOut
    {
        WorkerDepartament worker_d = WorkerDepartament.GetInstance();
        WorkerFacylty worker_f = WorkerFacylty.GetInstance();
        WorkerProfessor worker_p = WorkerProfessor.GetInstance();
        WorkerStudent worker_s = WorkerStudent.GetInstance();

        public bool IsDepartament(int id_number)
        {
            for (int i = 0; i < worker_d.departaments.Count; i++)
            {
                if (worker_d.departaments[i].ID_Struct == id_number)
                    return true;
            }
            return false;
        }

        public bool IsFacylty(int id_facylty)
        {
            for (int i = 0; i < worker_f.facylties.Count; i++)
            {
                if (id_facylty == worker_f.facylties[i].ID_Struct)
                    return true;
            }
            return false;
        }

        public bool IsStudent(int id_student)
        {
            for (int i = 0; i < worker_s.students.Count; i++)
            {
                if (id_student == worker_s.students[i].ID_Person)
                    return true;
            }
            return false;
        }

        public bool IsProfessor(int id_professor)
        {
            for (int i = 0; i < worker_p.professors.Count; i++)
            {
                if (id_professor == worker_p.professors[i].ID_Person)
                    return true;
            }
            return false;
        }
    }
}
