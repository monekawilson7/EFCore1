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
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }
        public DbSet<CourseInst> CourseInsts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ITIDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // StudCourse PK
            modelBuilder.Entity<StudCourse>()
                .HasKey(sc => new { sc.Stud_Id, sc.Course_Id });

            // CourseInst PK
            modelBuilder.Entity<CourseInst>()
                .HasKey(ci => new { ci.Inst_Id, ci.Course_Id });

            // Department -> Instructor (Manager)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manger)
                .WithMany()
                .HasForeignKey(d => d.Ins_Id);

            // Student -> Department
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dep_Id);

            // Instructor -> Department
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_Id);

            // Course -> Topic
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.Top_Id);
        }
    }
}
