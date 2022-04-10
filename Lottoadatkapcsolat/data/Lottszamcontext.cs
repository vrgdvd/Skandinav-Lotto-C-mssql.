using Lottoadatkapcsolat.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottoadatkapcsolat.data
{
    public class Lottszamcontext : DbContext
    {
        public DbSet<Lottoszam> LottoSzamok {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SzoftIILotto; Trusted_Connection=true");
        }
    }
}
