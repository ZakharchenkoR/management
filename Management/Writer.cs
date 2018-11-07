using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Management
{
    class Writer
    {
        WorkerStudent student = WorkerStudent.GetInstance();
        WorkerProfessor professor = WorkerProfessor.GetInstance();
        WorkerDepartament departament = WorkerDepartament.GetInstance();
        WorkerFacylty facylty = WorkerFacylty.GetInstance();

        public void WriteJsonStudent()
        {
            string jSon = JsonConvert.SerializeObject(student);
            File.WriteAllText("js.json", jSon);
        }

        public void WriteJsonProfessor()
        {
            string jSon = JsonConvert.SerializeObject(professor);
            File.WriteAllText("js_professor.json", jSon);
        }

        public void WriteJsonDeparatment()
        {
            string jSon  = JsonConvert.SerializeObject(departament);
            File.WriteAllText("js_deparatment.json", jSon);
        }

        public void WriteJsonFacylty()
        {
            string jSon = JsonConvert.SerializeObject(facylty);
            File.WriteAllText("js_facylty.json", jSon);
        }
    }
}
