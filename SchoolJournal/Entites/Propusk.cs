using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
    public class Propusk
    {
        public int Id { get; set; }
        public int Count { get; set; }

        public int QuarterId { get; set; }
        public virtual Quarter Quarter { get; set; }

        public int PupilId { get; set; }
        public virtual Pupil Pupil { get; set; }
    }
}
