using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class Informator
    {
        WorkerStudent student = WorkerStudent.GetInstance();
        WorkerProfessor professor = WorkerProfessor.GetInstance();
        WorkerDepartament departament = WorkerDepartament.GetInstance();
        WorkerFacylty facylty = WorkerFacylty.GetInstance();

        public void InformationInputDepartament()
        {
            for (int i = 0; i < departament.departaments.Count; i++)
            {
                Console.WriteLine($"\t\tДля добавления/удаления/редактирования кафедри: {departament.departaments[i].NameStruct},введите: {departament.departaments[i].ID_Struct}");
            }
        }

        public void InformationInputFacylty()
        {
            for (int i = 0; i < facylty.facylties.Count; i++)
            {
                Console.WriteLine($"\t\tДля добавления/удаления/редактирования факультета: {facylty.facylties[i].NameStruct},введите: {facylty.facylties[i].ID_Struct}");
            }
        }

        public void InformationINOutStudent()
        {
            for (int i = 0; i < student.students.Count; i++)
            {
                Console.WriteLine($"\t\tДля добавления/удаления/редактирования студента: {student.students[i].Name},введите: {student.students[i].ID_Person}");
            }
        }

        public void InformationInOutProfessor()
        {
            for (int i = 0; i < professor.professors.Count; i++)
            {
                Console.WriteLine($"\t\tДля добавления/удаления/редактирования профессора: {professor.professors[i].Name},введите: {professor.professors[i].ID_Person}");
            }
        }
    }
}
