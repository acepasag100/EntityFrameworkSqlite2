using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite2.Model
{
    public interface StudentAddressRepository
    {
        public void Add(StudentAddress studentAddress);
        public void Update(StudentAddress studentAddress);
        public void Delete(StudentAddress studentAddress);
        public IEnumerable<StudentAddress> GetAll();
        public IEnumerable<StudentAddress> GetAll(string value);
    }
}
