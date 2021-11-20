using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Userfrom.Entilien;

namespace testapp1.Entilien
{
    class Student
    {
        public string Id { get; internal set; }
        public string LastName { get; internal set; }
        public string FirsName { get; internal set; }
        public string PDB { get; internal set; }
        public string HomeTown { get; internal set; }
        public DateTime DDB { get; internal set; }
        public EGender Gender { get; internal set; }
        public string FullName {
            get {
                return $"{LastName} {FirsName}";
            }
        }
        public List<HistoryLearning> ListhistoryLearnings { get; set; }

        public static List<Student> List {
            get {
            var ls = new List<Student>();
                ls.Add(new Student()
                 {
                    LastName = "Nguyễn",
                    Id = "1",
                    FirsName = "Dũng",
                    DDB = new DateTime(2000, 2, 5),
                    PDB = "Phú Vang",
                    HomeTown = "Thừa Thiên Huế",
                    Gender = EGender.nam
                });
                ls.Add(new Student()
                {
                    LastName = "Nguyễn",
                    Id = "2",
                    FirsName = "Thị Thơm",
                    DDB = new DateTime(2001, 12, 15),
                    PDB = "Phú Vang",
                    HomeTown = "Thừa Thiên Huế",
                    Gender = EGender.nu
                }); 
                 return ls;
            }
            
        }

        public static Student Get(String id)
        {
            var dbStudent = GetList();
            var student = dbStudent.Where(s => s.Id == id).FirstOrDefault();
            return student;
        }

        private static object GetList()
        {
            throw new NotImplementedException();
        }

        public enum EGender
        {
            nam, nu, khác
        }

        /*internal Student Get(string idStudent)
        {
            throw new NotImplementedException();
        }*/
    }
}
