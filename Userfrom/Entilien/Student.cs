using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp1.Entilien
{
    class Student
    {
        internal string FullName;

        public object LastName { get; internal set; }
        public object FirsName { get; internal set; }
        public string PDB { get; internal set; }
        public string HomeTown { get; internal set; }
        public DateTime DDB { get; internal set; }
        public object Gender { get; internal set; }

        public static List<Student> GetList()
        {
            var ls = new List<Student>();
            ls.Add(new Student() {
                LastName = "Le",
                Id = "1",
                FirsName = "Nguyen Tri",
                DDB = new DateTime(2000,08,02),
                PDB = "Phu Vang",
                HomeTown = "Thua Thien Hue",
                Gender = EGender.Nam,


            }) ;
            ls.Add(new Student() {
                LastName = "Nguyen",
                Id = "2",
                FirsName = "Kim",
                DDB = new DateTime(2001, 8, 12),
                PDB = "Phu My",
                HomeTown = "Thua Thien Hue",
                Gender = EGender.Nu,
            });
        }

        public static Student Get(String id)
        {
            var dbStudent = GetList();
            // Ling to SQL
            var Student = dbStudent.Where(s => s.Id == id).FirstOrDefault();
            return Student;
        }
    }

    public enum EGender
    {
        Nam, Nu, Khac

    }
}
