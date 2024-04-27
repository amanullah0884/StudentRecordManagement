using System;
using System.Collections.Generic;

namespace StudentRecordManagement.Models
{
    public partial class Student
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Phone { get; set; }
        public string Gender { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}
