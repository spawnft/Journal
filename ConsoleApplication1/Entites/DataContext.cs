using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal.Entites
{
    public class DataContext : DbContext
    {
        
        public DataContext():base("DBConnection") {

        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassStatus> ClassStatuses { get; set; }
        public DbSet<Ocenka> Ocenki { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<PredmetiClass> PredmetiClasses { get; set; }
        public DbSet<Propusk> Propuski { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Quarter> Quarters { get; set; }
        public DbSet<TeachClass> TeachClasses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeachYear> TeachYears { get; set; }

    }
}
