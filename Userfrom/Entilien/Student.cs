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

        internal Student Get(string idStudent)
        {
            throw new NotImplementedException();
        }
    }
}
