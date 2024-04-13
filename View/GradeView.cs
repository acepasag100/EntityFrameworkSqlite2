using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite2.View
{
    public interface GradeView
    {
        public string GradeName { get; set; }   
        public void GradeBind(BindingSource bindingSource);
    }
}
