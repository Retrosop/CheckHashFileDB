using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShowHashFileNew
{


    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        public DbSet<Fileyandex> Fileyandex1s { get; set; }

        public DbSet<Meteostation> Meteostations1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=grandbook;", new MySqlServerVersion(new Version(10, 3, 0)));
        }
    }


}
