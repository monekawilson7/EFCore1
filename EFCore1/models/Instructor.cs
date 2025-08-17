using System.Collections.Generic;

namespace EFCore1.models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bonus { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }

        public int Dept_Id { get; set; }
        public Department Department { get; set; }
        public ICollection<CourseInst> CourseInsts { get; set; } = new List<CourseInst>();
    }
}
