﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.models
{
    public class Department
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; } = "";
        [Column(TypeName = "date")]
        public DateTime HiringDate { get; set; }
        public int Ins_Id { get; set; }
    }
}
