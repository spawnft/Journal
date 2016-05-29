using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
    public class TeachClass
    {
        public int Id { get; set; }

        public int? TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        
        public virtual ICollection<Pupil> Pupils { get; set; }
        public virtual ICollection<ClassStatus> ClassStatuses { get; set; }

        public TeachClass() {
            Pupils = new HashSet<Pupil>();
            ClassStatuses = new HashSet<ClassStatus>();
        }
    }
}
