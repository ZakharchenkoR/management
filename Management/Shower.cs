using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class Shower
    {
        WorkerStudent student = WorkerStudent.GetInstance();
        WorkerProfessor professor = WorkerProfessor.GetInstance();
        WorkerDepartament departament = WorkerDepartament.GetInstance();
        WorkerFacylty facylty = WorkerFacylty.GetInstance();
 
        public void ShowStudents(int position)
        {
            int position_departament = 0;
            for (int i = 0; i < departament.departaments.Count; i++)
            {
                if (student.students[position].ID_Departament == departament.departaments[i].ID_Struct)
                {
                    position_departament = i;
                    break;
                }
            }

            int position_facylty = 0;
            for (int i = 0; i < facylty.facylties.Count; i++)
            { 
                try
                {
                    if (departament.departaments[position_departament].ID_Fakylty == facylty.facylties[i].ID_Struct)
                    {
                        position_facylty = i;
                        break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Кафедра неопределена!");
                }
            }

            Console.WriteLine($"Имя студента:  {student.students[position].Name}");
            Console.WriteLine($"Факультет: {facylty.facylties[position_facylty].NameStruct}");
            try
            {
                Console.WriteLine($"Кафедра: {departament.departaments[position_departament].NameStruct}");
            }catch(Exception)
            {
                Console.WriteLine("Неопределено!");
            }
            try
            {
                Console.WriteLine($"Курс: {student.students[position].Kurs}");
            }
            catch(Exception)
            {
                Console.WriteLine("Неопределено!");
            }
            Console.WriteLine($"Возраст: {student.students[position].Age}");
            Console.WriteLine("=====================================");
        }

        public void ShowProfesso(int position)
        {
            int position_departament = 0;
            for (int i = 0; i < departament.departaments.Count; i++)
            {
                    try
                    {
                        if (professor.professors[position].ID_Departament == departament.departaments[i].ID_Struct)
                        {
                            position_departament = i;
                            break;
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                
            }

            int position_facylty = 0;
            for (int i = 0; i < facylty.facylties.Count; i++)
            {
                try
                {
                    if (departament.departaments[position_departament].ID_Fakylty == facylty.facylties[i].ID_Struct)
                    {
                        position_facylty = i;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Кафедра неопределена!");
                }
            }

            
            try
            {
                Console.WriteLine($"Профессор: {professor.professors[position].Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                Console.WriteLine($"Возраст: {professor.professors[position].Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine($"Факультет: {facylty.facylties[position_facylty].NameStruct}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неопределено");
            }
            try
            {
                Console.WriteLine($"Кафедра: {departament.departaments[position_departament].NameStruct}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неопределено");
            }
        }
    }
}
