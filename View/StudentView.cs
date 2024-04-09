using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite2.View
{
    public interface StudentView
    {
        public int StudentId { get; set; }

        public event EventHandler eventAdd;

        public void StudentBind(BindingSource bindingSource);
    }
}
