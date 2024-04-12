using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite2.Model
{
    public interface GradeRepository
    {
        public void Add(Grade grade);
        public void Update(Grade grade);
        public void Delete(Grade grade);
        public IEnumerable<String> GetAll();
        public Grade GetByValue(string name);
    }
}
