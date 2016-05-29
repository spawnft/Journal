using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }

        public virtual ICollection<TeachClass> TeachClasses { get; set; }
        public virtual ICollection<PredmetiClass> PredmetiClasses { get; set; }

        public Teacher() {
            TeachClasses = new HashSet<TeachClass>();
            PredmetiClasses = new HashSet<PredmetiClass>();
        }
    }
}
