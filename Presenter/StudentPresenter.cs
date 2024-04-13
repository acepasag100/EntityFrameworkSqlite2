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
        private StudentAdressView studentAdressView;
        private StudentRepository studentRepository;
        private GradeRepository gradeRepository;
        private StudentAddressRepository studentAddressRepository;
        private BindingSource studentBindingSource;
        private BindingSource gradeBindingSource;
        private IEnumerable<Student> students;
        private IEnumerable<String> grades;

        private Student? _student;
        private Grade? _grade;

        public StudentPresenter(object View, StudentRepository studentRepository, GradeRepository gradeRepository, StudentAddressRepository studentAddressRepository)
        {
            studentBindingSource = new BindingSource();
            gradeBindingSource = new BindingSource();

            this.gradeRepository = gradeRepository;
            this.studentAddressRepository = studentAddressRepository;
            this.studentRepository = studentRepository;

            this.gradeView = (GradeView)View;
            this.studentView = (StudentView)View;
            this.studentAdressView = (StudentAdressView)View;
            
            this.studentView.StudentBind(studentBindingSource);
            this.gradeView.GradeBind(gradeBindingSource);

            this.studentView.eventAdd += StudentView_eventAdd;
            this.studentView.eventUpdate += StudentView_eventUpdate;
            this.studentView.eventDelete += StudentView_eventDelete;
            this.studentView.eventCellClick += StudentView_eventCellClick;
            this.studentView.eventComboClick += StudentView_eventComboClick;

            load();
            StudentView_eventComboClick(null, null);
        }

        private void StudentView_eventComboClick(object? sender, EventArgs? e)
        {
            var item = (string)gradeBindingSource.Current;
            _grade = gradeRepository.GetByValue(item.ToString());
            this.studentView.GradeId = _grade.Id;
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

            this.studentView.GradeId = _grade.Id;
            this.gradeView.GradeName = _student.Grade.GradeName;

            this.studentAdressView.StudentAddressId = _student.StudentAddress.StudentAddressId;
            this.studentAdressView.Address = _student.StudentAddress.Address;
            this.studentAdressView.City = _student.StudentAddress.City;
            this.studentAdressView.State = _student.StudentAddress.State;
            this.studentAdressView.Country = _student.StudentAddress.Country;   
        }

        private void StudentView_eventDelete(object? sender, EventArgs e)
        {
            studentRepository.Delete(_student);
            load();
        }

        private void StudentView_eventUpdate(object? sender, EventArgs e)
        {
            studentRepository.Update(_student);
            load();
        }

        private void StudentView_eventAdd(object? sender, EventArgs e)
        {
            _student = new Student()
            {
                DateOfBirth = this.studentView.DateOfBirth,
                FirstName = this.studentView.FirstName,
                Height = this.studentView.Height,
                Weight = this.studentView.Weight,
                LastName = this.studentView.LastName,
                StudentAddress = new StudentAddress()
                {
                    Address = this.studentAdressView.Address,
                    City = this.studentAdressView.City,
                    Country = this.studentAdressView.Country,
                    State = this.studentAdressView.State,
                },
                GradeId = this.studentView.GradeId
            };
            studentRepository.Add(_student);
            load();
        }

        private void load()
        {
            students = studentRepository.GetAll();
            studentBindingSource.DataSource = this.students;

            grades = gradeRepository.GetAll();
            gradeBindingSource.DataSource = grades;

            _student = null;

            this.studentView.StudentId = -1;
            this.studentView.LastName = string.Empty;
            this.studentView.FirstName = string.Empty;
            this.studentView.DateOfBirth = DateTime.Now.ToString();
            this.studentView.Height = 0;
            this.studentView.Weight = 0;
            
            this.studentAdressView.StudentAddressId = -1;
            this.studentAdressView.Address = string.Empty;
            this.studentAdressView.City = string.Empty;
            this.studentAdressView.State = string.Empty;
            this.studentAdressView.Country = string.Empty;
        }
    }
}
