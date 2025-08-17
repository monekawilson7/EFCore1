using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.models
{
    public class StudCourse
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public double Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
