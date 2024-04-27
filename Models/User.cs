using System;
using System.Collections.Generic;

namespace StudentRecordManagement.Models
{
    public partial class User
    {
        public int User_id { get; set; }
        public int Password { get; set; }
        public string Type { get; set; } = null!;
    }
}
