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
        private GradeView gradeView;
        private StudentRepository studentRepository;
        private GradeRepository gradeRepository;
        private BindingSource studentBindingSource;
        private BindingSource gradeBindingSource;
        private IEnumerable<Student> students;
        private IEnumerable<String> grades;

        Student? _student;
        Grade? _grade;

        public StudentPresenter(StudentView studentView, GradeView gradeView, StudentRepository studentRepository, GradeRepository gradeRepository)
        {
            studentBindingSource = new BindingSource();
            gradeBindingSource = new BindingSource();
            this.gradeRepository = gradeRepository;
            this.gradeView = gradeView;
            this.studentView = studentView;
            this.studentRepository = studentRepository;
            this.studentView.StudentBind(studentBindingSource);
            this.gradeView.GradeBind(gradeBindingSource);
            this.studentView.eventAdd += StudentView_eventAdd;
            this.studentView.eventUpdate += StudentView_eventUpdate;
            this.studentView.eventDelete += StudentView_eventDelete;
            this.studentView.eventCellClick += StudentView_eventCellClick;
            this.studentView.eventComboClick += StudentView_eventComboClick;

            load();
        }

        private void StudentView_eventComboClick(object? sender, EventArgs e)
        {
            var item = (string)gradeBindingSource.Current;
            _grade = gradeRepository.GetByValue(item.ToString());
        }

        private void StudentView_eventCellClick(object? sender, EventArgs e)
        {
            _student = (Student)studentBindingSource.Current;
            this.studentView.StudentId = _student.StudentId;
            this.studentView.LastName = _student.LastName;
            this.studentView.FirstName = _student.FirstName;
            this.studentView.DateOfBirth = _student.DateOfBirth;
            this.studentView.Height = _student.Height;
            this.studentView.Weight = _student.Weight;
            this.gradeView.GradeName = gradeRepository.GetById(_student.GradeId);
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
            studentBindingSource.DataSource = this.students;

            grades = gradeRepository.GetAll();
            gradeBindingSource.DataSource = grades;
        }
    }
}
