using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
    public class Quarter
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int? ClassStatusId { get; set; }
        public virtual ClassStatus ClassStatus { get; set; }

        public virtual ICollection<Ocenka> Ocenki { get; set; }
        public virtual ICollection<Propusk> Propuski { get; set; }

        public Quarter() {
            Ocenki = new HashSet<Ocenka>();
            Propuski = new HashSet<Propusk>();
        }
    }
}
