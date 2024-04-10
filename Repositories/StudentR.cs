using EntityFrameworkSqlite2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite2.Repositories
{
    public class StudentR : Repository, StudentRepository
    {
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {   
            return Students.ToList(); 
        }

        public IEnumerable<Student> GetAll(string value)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
