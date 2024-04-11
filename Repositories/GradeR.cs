using EntityFrameworkSqlite2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite2.Repositories
{
    public class GradeR : Repository, GradeRepository
    {
        public void Add(Grade grade)
        {
            throw new NotImplementedException();
        }

        public void Delete(Grade grade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grade> GetAll()
        {
            return Grades.ToList();
        }

        public void Update(Grade grade)
        {
            throw new NotImplementedException();
        }
    }
}
