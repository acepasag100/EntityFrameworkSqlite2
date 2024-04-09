using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite2.Model
{
    public interface StudentRepository
    {
        public void Add(Student student);
        public void Update(Student student);
        public void Delete(Student student);
        public IEnumerable<Student> GetAll();
        public IEnumerable<Student> GetAll(string value);
    }
}
