using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
    public class ClassStatus
    {
        public int Id { get; set; }

        public int ClassId { get; set; }
        public virtual Class Class { get; set; }

        public int TeachYearId { get; set; }
        public virtual TeachYear TeachYear { get; set; }

        public int TeachClassId { get; set; }
        public virtual TeachClass TeachClass { get; set; }

        public virtual ICollection<PredmetiClass> PredmetiClasses { get; set; }
        public virtual ICollection<Quarter> Quarters { get; set; }

        public ClassStatus() {
            PredmetiClasses = new HashSet<PredmetiClass>();
            Quarters = new HashSet<Quarter>();
        }

    }
}
