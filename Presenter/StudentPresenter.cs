using EntityFrameworkSqlite2.Model;
using EntityFrameworkSqlite2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

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
            bindingSource = new BindingSource();
            this.studentView = studentView;
            this.studentRepository = studentRepository;
            this.studentView.StudentBind(bindingSource);
            this.studentView.eventAdd += StudentView_eventAdd;
            this.studentView.eventUpdate += StudentView_eventUpdate;
            this.studentView.eventDelete += StudentView_eventDelete;
            this.studentView.eventCellClick += StudentView_eventCellClick;

            load();
        }

        private void StudentView_eventCellClick(object? sender, EventArgs e)
        {
            var student = (Student)bindingSource.Current;
            this.studentView.StudentId = student.StudentId;
            this.studentView.LastName = student.LastName;
            this.studentView.FirstName = student.FirstName;
            this.studentView.DateOfBirth = student.DateOfBirth;
            this.studentView.Height = student.Height;
            this.studentView.Weight = student.Weight;
            //this.studentView.GradeId = student.GradeId;
        }

        private void StudentView_eventDelete(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StudentView_eventUpdate(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StudentView_eventAdd(object? sender, EventArgs e)
        {
            
        }

        private void load()
        {
            students = studentRepository.GetAll();
            bindingSource.DataSource = this.students;
        }
    }
}
