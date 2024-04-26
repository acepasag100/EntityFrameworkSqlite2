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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public event EventHandler eventAdd;
        public event EventHandler eventUpdate;
        public event EventHandler eventDelete;
        public event EventHandler eventCellClick;
        public event EventHandler eventComboClick;

        public void StudentBind(BindingSource bindingSource);
        //public void StudentGrade
    }
}
