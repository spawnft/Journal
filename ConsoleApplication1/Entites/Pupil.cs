using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
  public  class Pupil
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        
        public int? TeachClassId { get; set; }
        public virtual TeachClass TeachClass { get; set; }

        public virtual ICollection<Ocenka> Ocenki { get; set; }
        public virtual ICollection<Propusk> Propuski { get; set; }

        public Pupil()
        {
            Ocenki = new HashSet<Ocenka>();
            Propuski = new HashSet<Propusk>();
        }
    }
}
