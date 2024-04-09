using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite2.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        public StudentAddress StudentAddress { get; set; }
    }
}
