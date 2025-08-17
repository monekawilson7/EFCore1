using EFCore1.context;
using EFCore1.models;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            using (var db = new ITIContext())
            {
                // 1) Instructors
                var i1 = new Instructor { Name = "Omar", Bonus = 500, Salary = 8000, Address = "Alex", HourRate = 150 };
                var i2 = new Instructor { Name = "Nora", Bonus = 450, Salary = 7800, Address = "Cairo", HourRate = 140 };
                db.Instructors.AddRange(i1, i2);
                db.SaveChanges();

                // 2) Departments
                var d1 = new Department { Name = "CS", HiringDate = DateTime.Now, Ins_Id = i1.Id };
                var d2 = new Department { Name = "IS", HiringDate = DateTime.Now, Ins_Id = i2.Id };
                db.Departments.AddRange(d1, d2);
                db.SaveChanges();

                // 3) Topics
                var t1 = new Topic { Name = "Programming" };
                var t2 = new Topic { Name = "Databases" };
                db.Topics.AddRange(t1, t2);
                db.SaveChanges();

                // 4) Courses
                var c1 = new Course { Name = "C# Advanced", Duration = 60, Description = "Advanced C#", Top_Id = t1.Id, Dept_Id = d1.Id };
                var c2 = new Course { Name = "Database Design", Duration = 45, Description = "DB Concepts", Top_Id = t2.Id, Dept_Id = d2.Id };
                db.Courses.AddRange(c1, c2);
                db.SaveChanges();

                // 5) Students
                var s1 = new Student { FName = "Ali", LName = "Amir", Address = "Giza", Age = 22, Dep_Id = d1.Id };
                var s2 = new Student { FName = "Sara", LName = "Ahmed", Address = "Alex", Age = 23, Dep_Id = d2.Id };
                db.Students.AddRange(s1, s2);
                db.SaveChanges();

                // 6) Student-Courses (Many-to-Many)
                var sc1 = new StudCourse { Stud_Id = s1.Id, Course_Id = c1.Id, Grade = 90 };
                var sc2 = new StudCourse { Stud_Id = s1.Id, Course_Id = c2.Id, Grade = 85 };
                var sc3 = new StudCourse { Stud_Id = s2.Id, Course_Id = c1.Id, Grade = 88 };
                db.StudCourses.AddRange(sc1, sc2, sc3);
                db.SaveChanges();

                // 7) Course-Instructors (Many-to-Many)
                var ci1 = new CourseInst { Inst_Id = i1.Id, Course_Id = c1.Id, Evaluate = "Excellent" };
                var ci2 = new CourseInst { Inst_Id = i2.Id, Course_Id = c2.Id, Evaluate = "Very Good" };
                db.CourseInsts.AddRange(ci1, ci2);
                db.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
        }
    }
}
