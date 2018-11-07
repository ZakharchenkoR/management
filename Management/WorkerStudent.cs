using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class WorkerStudent
    {
        public List<Student> students = null;

        private static WorkerStudent instance;
        private WorkerStudent()
        {
            students = Student.GetStudents();
        }
        public static WorkerStudent GetInstance()
        {
            return instance ?? (instance = new WorkerStudent());
        }

        public void Add(string name,int age,int kurs,int id_departament)
        {
            students.Add(new Student(name, age, kurs, id_departament));
        }

        public void Delete(int id_for_delete)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if(id_for_delete == students[i].ID_Person)
                {
                    students.Remove(students[i]);
                    return;
                }

            }
        }

        public void Update(int id_student,int id_departament,string name,int age,int kurs)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if(students[i].ID_Person == id_student)
                {
                    students[i].Name = name;
                    students[i].ID_Departament = id_departament;
                    students[i].Age = age;
                    students[i].Kurs = kurs;
                    return;
                }
            }
        }
    }
}
