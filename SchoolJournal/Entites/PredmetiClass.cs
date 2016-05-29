using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
    public class PredmetiClass
    {
        public int Id { get; set; }

        public int PredmetId { get; set; }
        public virtual Predmet Predmet { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public int ClassStatusId { get; set; }
        public virtual ClassStatus ClassStatus { get; set; }

        public virtual ICollection<Ocenka> Ocenki { get; set; }
        public PredmetiClass()
        {
            Ocenki = new HashSet<Ocenka>();
        } 
    }
}
