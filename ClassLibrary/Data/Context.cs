using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{ 
    public class ClassLibrary : DbContext
    {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=Allatok;Trusted_Connection=True;");
    }
    public DbSet<>  { get; set; }
    public DbSet<>  { get; set; }
    }
}