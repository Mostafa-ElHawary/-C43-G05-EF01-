using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C43_G05_EF01.Entities;
using Microsoft.EntityFrameworkCore;

namespace C43_G05_EF01.Contexts
{
    // the AppDbContext is class represent database it's there in Microsoft.EntityFrameworkCore
    internal class AppDbContext  : DbContext
    {

        // OnConfiguring is a function to open conection with database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppG02; Trusted_Connection = True; TrustServerCertificate = True");
        }


        // Assignment  
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        // after these steps the next step to display these tables into database
        // we will use migration feature by 3 ways 1- c# code , 2- command line 3-  gui tool
        // we will use command line way => add-migration "initialCreate"  before this step
        // make shure you installed Microsoft.EntityFramework.Tool
        // then to aply the mirgration we will use command line update-database
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Date).IsRequired();
            });
        }
    }
}
