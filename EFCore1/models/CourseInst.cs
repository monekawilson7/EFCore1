using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.models
{
    public class CourseInst
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public string Evaluate { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}

