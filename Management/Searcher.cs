using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class Searcher
    {
        WorkerStudent student = WorkerStudent.GetInstance();
        WorkerProfessor professor = WorkerProfessor.GetInstance();
        WorkerDepartament departament = WorkerDepartament.GetInstance();
        WorkerFacylty facylty = WorkerFacylty.GetInstance();
        Shower show = new Shower();

        public void SerchNameStudent(string name_student)
        {
            var name = name_student.ToLower();
            for (int i = 0; i < student.students.Count; i++)
            {
                var student_n = student.students[i].Name.ToLower();
                if (name == student_n)
                {
                    show.ShowStudents(i);
                    return;
                }
            }
            Console.WriteLine("Студента с указаным имям нет!");
        }

        public void SearchNameProfessor(string name_professor)
        {
            var name = name_professor.ToLower();
            for (int i = 0; i < professor.professors.Count; i++)
            {
                var professor_n = professor.professors[i].Name.ToLower();
                if (name == professor_n)
                {
                    show.ShowProfesso(i);
                    return;
                }
            }
        }

        public void SerchKursStudent(int kurs_student_number)
        {
            for (int i = 0; i < student.students.Count; i++)
            {
                if (kurs_student_number == student.students[i].Kurs)
                    show.ShowStudents(i);
            }
        }

        public void SearchDepartamentStudent(int id_departament)
        {
            for (int i = 0; i < student.students.Count; i++)
            {
                if (id_departament == student.students[i].ID_Departament )
                    show.ShowStudents(i);
            }
        }

        public void SearchDepartamentProfessor(int id_departament)
        {
            for (int i = 0; i < professor.professors.Count; i++)
            {
                if (id_departament == professor.professors[i].ID_Departament)
                    show.ShowProfesso(i);
            }
        }

       public void OllStudentKursSort()
        {
            student.students.Sort();
            for (int i = 0; i < student.students.Count; i++)
            {
                show.ShowStudents(i);
            }
        }

        public void OllKursStudent(int number_kurs)
        {
            for (int i = 0; i < student.students.Count; i++)
            {
                if (number_kurs == student.students[i].Kurs)
                    show.ShowStudents(i);
            }
        }

        public void OllDepartamentStudenKurst(int num_departament, int number_kurs)
        {
            for (int i = 0; i < student.students.Count; i++)
            {
                if (num_departament == student.students[i].ID_Departament && number_kurs == student.students[i].Kurs)
                    show.ShowStudents(i);
            }
        }

        public void SortDepartamentProfessor(int id_departament)
        {
            professor.professors.Sort();
            for (int i = 0; i < professor.professors.Count; i++)
            {
                if (id_departament == professor.professors[i].ID_Departament)
                    show.ShowProfesso(i);
            }
        }
    }
}
