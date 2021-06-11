using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace GroceryLog2.Models
{
    public class GroceriesDbContext: DbContext
    {
        public DbSet<Groceries> Groceries { get; set; }
   
        public GroceriesDbContext(DbContextOptions<GroceriesDbContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Groceries>().ToTable("Groceries");
        }
    }

}
