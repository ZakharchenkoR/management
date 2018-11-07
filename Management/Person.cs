using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    abstract class Person
    {
        public static int LastID = 1;
        public string Name { get; set; }
        public int Age { get; set; }
        public int ID_Departament { get; set; }
        private int id_person;

        public int ID_Person
        {
            get
            {
                return id_person;
            }
        }

        public Person(string name, int age, int id_departament)
        {
            Name = name;
            Age = age;
            ID_Departament = id_departament;
            id_person = LastID++;
        }
       
    }
}
