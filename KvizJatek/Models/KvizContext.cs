using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KvizJatek.Models
{
    public class KvizContext : DbContext
    {
        public DbSet<Kerdes> Kerdes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConnectionString
            string c = "server = localhost; userid = root; password =; database = KvizJatek";

            //OptionBulider: ConnectionString + Szerver verzió (manuálisan, vagy Autodetect)
            optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));


        }
    }
}
