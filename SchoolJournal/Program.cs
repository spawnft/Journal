using SchoolJournal.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolJournal
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (DataContext b = new DataContext())
            {
                //User u = new User();
                //u.Name = "fe";
                //u.Surname = "Hello WOrld";
                //b.Users.Add(u);
                //b.SaveChanges();

                //Predmet e = new Predmet();
                //e.Id = 4;

                //int sum = b.Users.Sum(us => us.Surname) / b.Users.Count();
                //Console.WriteLine(sum);

                var p = b.Pupils.ToList();

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
