using EntityFrameworkSqlite2.Model;
using EntityFrameworkSqlite2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite2.Presenter
{
    public class StudentPresenter
    {
        private StudentView studentView;
        private StudentRepository studentRepository;
        private BindingSource bindingSource;
        private IEnumerable<Student> students;

        public StudentPresenter(StudentView studentView, StudentRepository studentRepository)
        {
            this.studentView = studentView;
            this.studentRepository = studentRepository;
            this.studentView.StudentBind(bindingSource);
            this.studentView.eventAdd += StudentView_eventAdd;

            load();
        }

        private void StudentView_eventAdd(object? sender, EventArgs e)
        {
            
        }

        private void load()
        {
            this.students = studentRepository.GetAll();
            bindingSource.DataSource = this.students;
        }
    }
}
