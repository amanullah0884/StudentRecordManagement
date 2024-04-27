using System;
using System.Collections.Generic;

namespace StudentRecordManagement.Models
{
    public partial class Teacher
    {
        public int Teacher_Id { get; set; }
        public string Teacher_Name { get; set; } = null!;
        public string Teacher_Course { get; set; } = null!;
    }
}
