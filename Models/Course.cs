using System;
using System.Collections.Generic;

namespace StudentRecordManagement.Models
{
    public partial class Course
    {
        public string Course_id { get; set; } = null!;
        public string? Course_Name { get; set; }
        public string? Credit { get; set; }
    }
}
