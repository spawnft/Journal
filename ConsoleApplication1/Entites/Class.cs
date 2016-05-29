using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
     public class Class
    {

        public int Id { get; set; }
        public int  NumClass { get; set; }
        public string CharClass { get; set; }

        public virtual ICollection<ClassStatus> ClassStatuses { get; set; }

        public Class() {
            ClassStatuses = new HashSet<ClassStatus>();
        }
    }
}
 