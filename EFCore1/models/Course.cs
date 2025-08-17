using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.models
{
    public class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Top_Id { get; set; }

        public Topic Topic { get; set; }
        public int Dept_Id { get; set; }
        public Department Department { get; set; }

        public ICollection<StudCourse> StudCourses { get; set; } = new List<StudCourse>();
        public ICollection<CourseInst> CourseInsts { get; set; } = new List<CourseInst>();
    }
}
