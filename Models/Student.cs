using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string? Name { get; set; } //wajib diisi pake ?
        public string? Email { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}