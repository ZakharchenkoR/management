using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class Menu
    {
        Informator informator = new Informator();
        ChekingOut cheking = new ChekingOut();
        WorkerStudent workerStudent = WorkerStudent.GetInstance();
        WorkerProfessor workerProfessor = WorkerProfessor.GetInstance();
        WorkerDepartament workerDepartament = WorkerDepartament.GetInstance();
        WorkerFacylty workerFacylty = WorkerFacylty.GetInstance();
        Searcher searcher = new Searcher();
        Writer writer = new Writer();
        bool exit;
        bool exit_show;
        bool exit_delete;
        bool exit_add;
        bool exit_searh;
        bool exit_serch_menu_p;
        bool exit_save;
        bool exit_update;

        public Menu()
        {
            exit = false;
            exit_show = false;
            exit_delete = false;
            exit_add = false;
            exit_searh = false;
            exit_serch_menu_p = false;
            exit_save = false;
            exit_update = false;
        }
       
        public void Menu_Work()
        {

           
            while (!exit)
            {
                Console.WriteLine("Меню программы:");
                Console.WriteLine("\t- добавить\"add\"");
                Console.WriteLine("\t- удалить\"delete\"");
                Console.WriteLine("\t- поиск и вывод\"search\"");
                Console.WriteLine("\t- радактировать\"update\"");
                Console.WriteLine("\t- показать \"show\"");
                Console.WriteLine("\t- сохранить\"save\"");
                Console.WriteLine("\t- покинуть программу\"exit\"");
                Console.WriteLine("\t-очистить екран\"clear\"");
                Console.WriteLine("Введите команду: ");
                string command = InputData.EnterString();
                switch (command)
                {
                    case "add":
                        {
                            exit_add = false;
                            while (!exit_add)
                            {
                                Console.WriteLine("\tМеню добавлений: ");
                                Console.WriteLine("\t\t- добавить студента\"student\"");
                                Console.WriteLine("\t\t- добавить преподавателя\"professor\"");
                                Console.WriteLine("\t\t- добавить кафедру\"departament\"");
                                Console.WriteLine("\t\t- добавить факультет\"facylty\"");
                                Console.WriteLine("\t\t- очистить екран\"clear\"");
                                Console.WriteLine("\t\t- вийти с меню\"exit\"");
                                Console.WriteLine("Введите команду: ");
                                string command_add = InputData.EnterString();
                                switch (command_add)
                                {
                                    case "student":
                                        Console.Write("введите имя студента: ");
                                        string name = InputData.EnterString();
                                        Console.Write("введите возраст: ");
                                        int age = InputData.EnterNumber();
                                        Console.Write("введите курс: ");
                                        int kurs = InputData.EnterNumber();

                                        informator.InformationInputDepartament();
                                        Console.Write("введите департамент: ");
                                        int id_dep = InputData.EnterNumber();
                                        bool is_dep = cheking.IsDepartament(id_dep);
                                        while (!is_dep)
                                        {
                                            Console.Write("введите департамент: ");
                                            id_dep = InputData.EnterNumber();
                                            is_dep = cheking.IsDepartament(id_dep);
                                        }
                                        workerStudent.Add(name, age, kurs, id_dep);
                                        break;
                                    case "professor":
                                        Console.Write("введите имя преподавателя: ");
                                        string name_p = InputData.EnterString();
                                        Console.Write("введите возраст: ");
                                        int age_p = InputData.EnterNumber();

                                        informator.InformationInputDepartament();
                                        Console.Write("введите департамент: ");
                                        int id_dep_p = InputData.EnterNumber();
                                        bool is_dep_p = cheking.IsDepartament(id_dep_p);
                                        while (!is_dep_p)
                                        {
                                            Console.Write("введите департамент: ");
                                            id_dep_p = InputData.EnterNumber();
                                            is_dep_p = cheking.IsDepartament(id_dep_p);
                                        }
                                        workerProfessor.Add(name_p, age_p, id_dep_p);
                                        break;
                                    case "departament":
                                        Console.Write("введите название кафедры: ");
                                        string name_k = InputData.EnterString();
                                        informator.InformationInputFacylty();
                                        Console.Write("введите факультет: ");
                                        int id_facylty = InputData.EnterNumber();
                                        bool is_facylty = cheking.IsFacylty(id_facylty);
                                        while (!is_facylty)
                                        {
                                            Console.Write("введите факультет: ");
                                            id_facylty = InputData.EnterNumber();
                                            is_facylty = cheking.IsFacylty(id_facylty);
                                        }
                                        workerDepartament.Add(name_k, id_facylty);
                                        break;
                                    case "facylty":
                                        Console.Write("введите название факультета: ");
                                        string name_facylty = InputData.EnterString();
                                        workerFacylty.Add(name_facylty);
                                        break;
                                    case "clear":
                                        Console.Clear();
                                        break;
                                    case "exit":
                                        exit_add = true;
                                        break;
                                    default:
                                        Console.WriteLine("Неверная команда!");
                                        break;
                                }

                            }
                        }
                        break;
                    case "delete":
                        {
                            exit_delete = false;
                            while (!exit_delete)
                            {
                                Console.WriteLine("\tМеню удалений: ");
                                Console.WriteLine("\t\t- удалить студента\"student\"");
                                Console.WriteLine("\t\t- удалить преподавателя\"professor\"");
                                Console.WriteLine("\t\t- удалить кафедру\"departament\"");
                                Console.WriteLine("\t\t- удалить факультет\"facylty\"");
                                Console.WriteLine("\t\t- очистить екран\"clear\"");
                                Console.WriteLine("\t\t- вийти с меню\"exit\"");
                                Console.WriteLine("Введите команду: ");
                                string command_delete = InputData.EnterString();
                                switch (command_delete)
                                {
                                    case "student":
                                        informator.InformationINOutStudent();
                                        Console.Write("введите id студента: ");
                                        int id_s = InputData.EnterNumber();
                                        if (cheking.IsStudent(id_s))
                                        {
                                            workerStudent.Delete(id_s);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы питаетесь удалить несуществующего студента!");
                                        }
                                        break;
                                    case "professor":
                                        informator.InformationInOutProfessor();
                                        Console.Write("введите id преподавателя: ");
                                        int id_p = InputData.EnterNumber();
                                        if (cheking.IsProfessor(id_p))
                                            workerProfessor.Delete(id_p);
                                        else
                                            Console.WriteLine("Вы питаетесь удалить несуществующего преподавателя!");
                                        break;
                                    case "departament":
                                        informator.InformationInputDepartament();
                                        Console.Write("введите id кафедры: ");
                                        int id_d = InputData.EnterNumber();
                                        if (cheking.IsDepartament(id_d))
                                            workerDepartament.Delete(id_d);
                                        else
                                            Console.WriteLine("Вы питаетесь удалить несуществующую кафедру!");
                                        break;
                                    case "facylty":
                                        informator.InformationInputFacylty();
                                        Console.Write("введите id факультета: ");
                                        int id_f = InputData.EnterNumber();
                                        if (cheking.IsFacylty(id_f))
                                            workerFacylty.Delete(id_f);
                                        else
                                            Console.WriteLine("Вы питаетесь удалить несуществующий факультет!");
                                        break;
                                    case "clear":
                                        Console.Clear();
                                        break;
                                    case "exit":
                                        exit_delete = true;
                                        break;
                                    default:
                                        Console.WriteLine("Неверная команда!");
                                        break;
                                }
                            }
                        }
                        break;
                    case "save":
                        {
                            exit_save = false;
                            while(!exit_save)
                            {
                                Console.WriteLine();
                                Console.WriteLine("\t- сохнанить студентов \"student\"");
                                Console.WriteLine("\t- сохнанить преподавателей \"professor\"");
                                Console.WriteLine("\t- сохнанить кафедры \"departament\"");
                                Console.WriteLine("\t- сохнанить факультеты \"facylty\"");
                                Console.WriteLine("\t- сохнанить все \"oll\"");
                                Console.WriteLine("\t- виход из меню \"exit\"");
                                Console.Write("\t- введите команду: ");
                                string command_save = InputData.EnterString();

                                switch(command_save)
                                {
                                    case "student":
                                        writer.WriteJsonStudent();
                                        break;
                                    case "professor":
                                        writer.WriteJsonProfessor();
                                        break;
                                    case "departament":
                                        writer.WriteJsonDeparatment();
                                        break;
                                    case "facylty":
                                        writer.WriteJsonFacylty();
                                        break;
                                    case "oll":
                                        writer.WriteJsonStudent();
                                        writer.WriteJsonProfessor();
                                        writer.WriteJsonDeparatment();
                                        writer.WriteJsonFacylty();
                                        break;
                                    case "exit":
                                        exit_save = true;
                                        break;
                                    default:
                                        Console.WriteLine("Неверная команда!");
                                        break;
                                }
                            }
                        }
                        break;
                    case "search":
                        {
                            exit_searh = false;
                            while (!exit_searh)
                            {
                                Console.WriteLine("\tМеню поиска:");
                                Console.WriteLine("\t\t- найти студента\"student\"");
                                Console.WriteLine("\t\t- найти преподавателя\"professor\"");
                                Console.WriteLine("\t\t- очистить екран\"clear\"");
                                Console.WriteLine("\t\t- виход из меню\"exit\"");
                                Console.Write("введите команду: ");
                                string command_search = InputData.EnterString();
                                switch (command_search)
                                {
                                    case "student":
                                        {
                                            bool exit_serch_menu = false;
                                            while (!exit_serch_menu)
                                            {
                                                Console.WriteLine("Поиск по: ");
                                                Console.WriteLine("\t- имени \"name\"");
                                                Console.WriteLine("\t- курсу \"kurs\"");
                                                Console.WriteLine("\t- кафедре \"departament\"");
                                                Console.WriteLine("\t- виход из меню\"exit\"");
                                                Console.Write("введите команду: ");
                                                string com_search = InputData.EnterString();

                                                switch (com_search)
                                                {
                                                    case "name":
                                                        Console.WriteLine("введите имя студента: ");
                                                        string name_student_search = InputData.EnterString();
                                                        searcher.SerchNameStudent(name_student_search);
                                                        break;
                                                    case "kurs":
                                                        Console.WriteLine("введите курс студента: ");
                                                        int kurs_student = InputData.EnterNumber();
                                                        searcher.SerchKursStudent(kurs_student);
                                                        break;
                                                    case "departament":
                                                        informator.InformationInputDepartament();
                                                        Console.WriteLine("введите id кафедры: ");
                                                        int id_dep = InputData.EnterNumber();
                                                        searcher.SearchDepartamentStudent(id_dep);
                                                        break;
                                                    case "exit":
                                                        exit_serch_menu = true;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Неверная команда!");
                                                        break;

                                                }
                                            }
                                        }

                                        break;
                                    case "professor":
                                        exit_serch_menu_p = false;
                                        while (!exit_serch_menu_p)
                                        {
                                            Console.WriteLine("Поиск по: ");
                                            Console.WriteLine("\t- имени \"name\"");
                                            Console.WriteLine("\t- кафедре \"departament\"");
                                            Console.WriteLine("\t- виход из меню\"exit\"");
                                            Console.Write("введите команду: ");
                                            string com_search = InputData.EnterString();

                                            switch (com_search)
                                            {
                                                case "name":
                                                    Console.WriteLine("введите имя профессора: ");
                                                    string name_professor_search = InputData.EnterString();
                                                    searcher.SearchNameProfessor(name_professor_search);
                                                    break;
                                                case "departament":
                                                    informator.InformationInputDepartament();
                                                    Console.WriteLine("введите id кафедры: ");
                                                    int id_dep = InputData.EnterNumber();
                                                    searcher.SearchDepartamentProfessor(id_dep);
                                                    break;
                                                case "exit":
                                                    exit_serch_menu_p = true;
                                                    break;
                                                default:
                                                    Console.WriteLine("Неверная команда!");
                                                    break;
                                            }
                                        }
                                        break;
                                    case "clear":
                                        Console.Clear();
                                        break;
                                    case "exit":
                                        exit_searh = true;
                                        break;
                                    default:
                                        Console.WriteLine("Неверная команда!");
                                        break;
                                }
                            }
                        }
                        break;
                    case "show":
                        exit_show = false;
                        while (!exit_show)
                        {
                            Console.WriteLine("\t- все студенты отсортированы по курсу \"sort_kurs\"");
                            Console.WriteLine("\t- все студенты определенного курса\"student_kurs\"");
                            Console.WriteLine("\t- все студенты курса определенного департамента \"student_kurs_departament\"");
                            Console.WriteLine("\t- все преподаватели курса упорядоченые по алфавиту \"professor_sort_dep\"");
                            Console.WriteLine("\t- очистить екран \"clear\"");
                            Console.WriteLine("\t- виход из меню\"exit\"");
                            Console.Write("введите команду: ");
                            string command_show = InputData.EnterString();
                            switch(command_show)
                            {
                                case "sort_kurs":
                                    searcher.OllStudentKursSort();
                                    break;
                                case "student_kurs":
                                    Console.Write("введите номер курса: ");
                                    int num_kurs = InputData.EnterNumber();
                                    searcher.SerchKursStudent(num_kurs);
                                    break;
                                case "student_kurs_departament":
                                    Console.Write("введите номер курса: ");
                                    int num_k_st = InputData.EnterNumber();
                                    informator.InformationInputDepartament();
                                    Console.Write("введите id департамента: ");
                                    int id_dep = InputData.EnterNumber();
                                    searcher.OllDepartamentStudenKurst(id_dep, num_k_st);
                                    break;
                                case "professor_sort_dep":
                                    informator.InformationInputDepartament();
                                    Console.WriteLine("введите id кафедры: ");
                                    int id_dep_s = InputData.EnterNumber();
                                    searcher.SortDepartamentProfessor(id_dep_s);
                                    break;
                                case "clear":
                                    Console.Clear();
                                    break;
                                case "exit":
                                    exit_show = true;
                                    break;
                                default:
                                    Console.WriteLine("Неверная команда!");
                                    break;
                                    
                            }
                        }
                            break;
                    case "update":
                        exit_update = false;
                        while(!exit_update)
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t- редактировать студента \"student\"");
                            Console.WriteLine("\t- редактировать преподавателя \"professor\"");
                            Console.WriteLine("\t- редактировать кафедру \"departament\"");
                            Console.WriteLine("\t- редактировать факультет \"facylty\"");
                            Console.WriteLine("\t- выход \"exit\"");
                            Console.Write("введите команду: ");
                            string command_uplade = InputData.EnterString();

                            switch (command_uplade)
                            {
                                case "student":
                                    informator.InformationINOutStudent();
                                    Console.Write("введите id студента: ");
                                    int id_std = InputData.EnterNumber();
                                    if(cheking.IsStudent(id_std))
                                    {
                                        Console.Write("введите новое имя: ");
                                        string new_name = InputData.EnterString();
                                        Console.Write("введите новый возраст: ");
                                        int new_age = InputData.EnterNumber();
                                        informator.InformationInputDepartament();
                                        Console.Write("введите id кафедры: ");
                                        int new_id = InputData.EnterNumber();
                                        Console.Write("введите новый курс: ");
                                        int new_kurs = InputData.EnterNumber();
                                        workerStudent.Update(id_std, new_id, new_name, new_age, new_kurs);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Студента не существует!");
                                    }
                                    break;
                                case "professor":
                                    informator.InformationInOutProfessor();
                                    Console.Write("введите id преподавателя: ");
                                    int id_professor = InputData.EnterNumber();
                                    if(cheking.IsProfessor(id_professor))
                                    {
                                        Console.Write("введите новое имя: ");
                                        string new_name = InputData.EnterString();
                                        Console.Write("введите новый возраст: ");
                                        int new_age = InputData.EnterNumber();
                                        informator.InformationInputDepartament();
                                        Console.Write("введите id кафедры: ");
                                        int new_id = InputData.EnterNumber();
                                        workerProfessor.Update(id_professor, new_id, new_age, new_name);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Преподавателя не существует!");
                                    }
                                    break;
                                case "departament":
                                    informator.InformationInputDepartament();
                                    Console.Write("введите id кафедры: ");
                                    int id_dep = InputData.EnterNumber();
                                    if(cheking.IsDepartament(id_dep))
                                    {
                                        Console.Write("введите новое имя: ");
                                        string new_name = InputData.EnterString();
                                        informator.InformationInputFacylty();
                                        Console.Write("введите id факультета: ");
                                        int new_id = InputData.EnterNumber();
                                        workerDepartament.Update(id_dep, new_id, new_name);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Кафедры не существует!");
                                    }
                                    break;
                                case "facylty":
                                    informator.InformationInputFacylty();
                                    Console.Write("введите id факультета: ");
                                    int id_facylty = InputData.EnterNumber();
                                    if(cheking.IsFacylty(id_facylty))
                                    {
                                        Console.Write("введите новое имя: ");
                                        string new_name = InputData.EnterString();
                                        workerFacylty.Update(id_facylty, new_name);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Факультета не существует!");
                                    }
                                    break;
                                case "exit":
                                    exit_update = true;
                                    break;
                                default:
                                    Console.WriteLine("Неверная команда!");
                                    break;
                            }
                        }
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        Console.WriteLine("Програма завершена");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("неверна команда!");
                        break;
                }
            }
        }
    }
}

