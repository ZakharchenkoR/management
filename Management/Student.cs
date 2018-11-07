using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class Student: Person,IComparable,IComparer<Student>
    {
        public int Kurs { get; set; }
        public Student(string name, int age, int kurs, int id_departament):base(name,age,id_departament)
        {
            Name = name;
            Age = age;
            Kurs = kurs;
            ID_Departament = id_departament;
        }

      
        public  static  List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student("Petrov Igor",21,1,1),
                new Student("Ivanov Ivan",19,2,1),
                new Student("Zaharchenko Stepan",20,3,2),
                new Student("Mironenko Yaroslav",22,4,1),
                new Student("Romanishin Sviyatoslav",22,1,2),
                new Student("Karpow Den",17,4,1),
                new Student("Gavrilov Mihail",18,3,2),
                new Student("Zembitska Tatyana",25,2,1),
                new Student("Lavrenchuk Valeriya",20,1,2),
                new Student("Rusinka Miroslava",20,2,1),
                new Student("Yaroshuck Marina",20,3,2),
                new Student("Kolesnick Ludmila",23,4,1),
                new Student("Melnick Igor",21,1,1),
                new Student("Matvienko Dmitriy",21,2,1),
                new Student("Ignatenko Ivan",20,3,2),
                new Student("Yarmolenko Andriy",18,4,2),
                new Student("Bugarenko Lena",19,1,2),
                new Student("Tarchenko Sasha",20,2,1),
                new Student("Feduk Roman",21,3,2)
            };
        }

        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            if(student != null)
            {
                return this.Kurs.CompareTo(student.Kurs);
            }
            else
            {
                throw new Exception("This sort is not true!");
            }
        }

        public int Compare(Student x, Student y)
        {
            if (x.Kurs > y.Kurs)
                return 1;
            else if (x.Kurs < y.Kurs)
                return -1;
            else
                return 0;
        }

        
    }
}
