using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { StudentID = 1, Name = "Josephine Vania Soerjanto", Email = "josephine@gmail.com", BirthDate = new DateOnly(2002, 2, 2)},
            new Student { StudentID = 2, Name = "Jennifer S", Email = "jenia@gmail.com", BirthDate = new DateOnly(2001, 5, 1)},
            new Student { StudentID = 3, Name = "Jessica S", Email = "jessi@gmail.com", BirthDate = new DateOnly(2001, 5, 4)},
        };

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.First(s => s.StudentID == id);
        }
    }
}