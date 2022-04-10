using LottoAdatKapcsolatt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoAdatKapcsolatt.Data
{
    public class LottoSzamContext : DbContext
    {
        public DbSet <LottoSzam> LottoSzamok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SzoftIILotto;Trusted_Connection=true");
        }
    }
}
