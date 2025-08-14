using EFCore1.context;
using EFCore1.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCore1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new ITIContext();
            db.Database.Migrate();

            var s1 = new Student { FName = "Ali", LName = "Hassan", Address = "Cairo", Age = 21, Dep_Id = 10 };
            var s2 = new Student { FName = "Sara", LName = "Adel", Address = "Giza", Age = 22, Dep_Id = 20 };
            db.Students.AddRange(s1, s2);

            var t1 = new Topic { Name = "Databases" };
            var t2 = new Topic { Name = "Programming" };
            db.Topics.AddRange(t1, t2);

            var d1 = new Department { Name = "CS", HiringDate = new DateTime(2020, 1, 1), Ins_Id = 100 };
            var d2 = new Department { Name = "IS", HiringDate = new DateTime(2021, 6, 1), Ins_Id = 200 };
            db.Departments.AddRange(d1, d2);

            var c1 = new Course { Duration = 30, Name = "C# Basics", Description = "Intro course", Top_Id = 1 };
            var c2 = new Course { Duration = 40, Name = "SQL", Description = "Database course", Top_Id = 1 };
            db.Courses.AddRange(c1, c2);
            var i1 = new Instructor { Name = "Omar", Bonus = 500, Salary = 8000, Address = "Alex", HourRate = 150, Dept_Id = 1 };
            var i2 = new Instructor { Name = "Nora", Bonus = 450, Salary = 7800, Address = "Cairo", HourRate = 140, Dept_Id = 2 };
            db.Instructors.AddRange(i1, i2);
            var sc1 = new StudCourse { Stud_ID = 1, Course_ID = 1, Grade = 85.5 };
            var sc2 = new StudCourse { Stud_ID = 2, Course_ID = 2, Grade = 90.0 };
            db.Stud_Course.AddRange(sc1, sc2);

            var ci1 = new CourseInst { Inst_ID = 1, Course_ID = 1, Evaluate = "Good" };
            var ci2 = new CourseInst { Inst_ID = 2, Course_ID = 2, Evaluate = "Very Good" };
            db.Course_inst.AddRange(ci1, ci2);

            db.SaveChanges();
            Console.WriteLine("CREATE done.");
            Console.WriteLine("\nREAD all rows:");
            Console.WriteLine($"Students: {db.Students.Count()}");
            Console.WriteLine($"Topics: {db.Topics.Count()}");
            Console.WriteLine($"Departments: {db.Departments.Count()}");
            Console.WriteLine($"Courses: {db.Courses.Count()}");
            Console.WriteLine($"Instructors: {db.Instructors.Count()}");
            Console.WriteLine($"Stud_Course rows: {db.Stud_Course.Count()}");
            Console.WriteLine($"Course_inst rows: {db.Course_inst.Count()}");
            var st = db.Students.First();
            st.Address = "Cairo - Nasr City";

            var top = db.Topics.First();
            top.Name = "DB Systems";

            var dep = db.Departments.First();
            dep.HiringDate = dep.HiringDate.AddDays(1);

            var crs = db.Courses.First();
            crs.Description = "Intro to C# and .NET";

            var ins = db.Instructors.First();
            ins.Bonus += 100;

            var sc = db.Stud_Course.Find(1, 1); 
            if (sc != null) sc.Grade = 88.0;

            var ci = db.Course_inst.Find(1, 1); 
            if (ci != null) ci.Evaluate = "Excellent";

            db.SaveChanges();
            Console.WriteLine("\nUPDATE done.");

            var stDel = db.Students.OrderBy(x => x.Id).Last();
            db.Students.Remove(stDel);

            var topDel = db.Topics.OrderBy(x => x.Id).Last();
            db.Topics.Remove(topDel);

            var depDel = db.Departments.OrderBy(x => x.Id).Last();
            db.Departments.Remove(depDel);

            var crsDel = db.Courses.OrderBy(x => x.Id).Last();
            db.Courses.Remove(crsDel);

            var insDel = db.Instructors.OrderBy(x => x.Id).Last();
            db.Instructors.Remove(insDel);

            var scDel = db.Stud_Course.Find(2, 2);
            if (scDel != null) db.Stud_Course.Remove(scDel);

            var ciDel = db.Course_inst.Find(2, 2);
            if (ciDel != null) db.Course_inst.Remove(ciDel);
            db.SaveChanges();
            Console.WriteLine("\nDELETE done.");
            Console.WriteLine($"\nAfter DELETE -> Students: {db.Students.Count()}, Topics: {db.Topics.Count()}, Departments: {db.Departments.Count()}, Courses: {db.Courses.Count()}, Instructors: {db.Instructors.Count()}, Stud_Course: {db.Stud_Course.Count()}, Course_inst: {db.Course_inst.Count()}");
        }
    }
}
