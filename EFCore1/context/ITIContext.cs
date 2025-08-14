using EFCore1.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.context
{
    internal class ITIContext : DbContext
    {
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Topic> Topics => Set<Topic>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Instructor> Instructors => Set<Instructor>();
        public DbSet<StudCourse> Stud_Course => Set<StudCourse>();
        public DbSet<CourseInst> Course_inst => Set<CourseInst>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyDbName;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
        modelBuilder.Entity<Course>(e =>
        {
            e.ToTable("Course");
            e.HasKey(x => x.Id);
            e.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);          
            e.Property(x => x.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
        });
            modelBuilder.Entity<Instructor>(e =>
            {
                e.ToTable("Instructor");
                e.HasKey(x => x.Id);
                e.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
                e.Property(x => x.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudCourse>(e =>
            {
                e.ToTable("Stud_Course");
                e.HasKey(x => new { x.Stud_ID, x.Course_ID });
            });

            modelBuilder.Entity<CourseInst>(e =>
            {
                e.ToTable("Course_inst");
                e.HasKey(x => new { x.Inst_ID, x.Course_ID });
                e.Property(x => x.Evaluate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }

    }
}
