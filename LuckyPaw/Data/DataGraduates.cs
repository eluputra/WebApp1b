using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuckyPaw.Models;
using Microsoft.EntityFrameworkCore;

// Creating database for the dog and enrollment and type of services 
namespace LuckyPaw.Data
{
    public class DataGraduates : DbContext
    {
        public DataGraduates(DbContextOptions<DataGraduates> options) : base(options)
        {
        }

        public DbSet<Services> type { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Graduates> Graduates { get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Services>().ToTable("type");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Graduates>().ToTable("dogName");
        }
    }
}
