using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
    public class TeachYear
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<ClassStatus> ClassStatuses { get; set; }

        public TeachYear()
        {
            ClassStatuses = new HashSet<ClassStatus>();
        }
    }
}
