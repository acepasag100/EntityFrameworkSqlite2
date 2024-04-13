using EntityFrameworkSqlite2.Model;
using EntityFrameworkSqlite2.Presenter;
using EntityFrameworkSqlite2.Repositories;
using EntityFrameworkSqlite2.View;

namespace EntityFrameworkSqlite2
{
    public partial class Form1 : Form, StudentView, GradeView
    {
        Repository repository = new Repository();
        public Form1()
        {
            InitializeComponent();
            Load += delegate
            {
                StudentRepository repository = new StudentR();
                GradeRepository gradeRepository = new GradeR();
                StudentPresenter presenter = new StudentPresenter(this, this, repository, gradeRepository);
            };
            btnAdd.Click += delegate
            {
                eventAdd?.Invoke(this, EventArgs.Empty);
            };
            btnDelete.Click += delegate
            {
                eventDelete?.Invoke(this, EventArgs.Empty);
            };
            btnUpdate.Click += delegate
            {
                eventUpdate?.Invoke(this, EventArgs.Empty);
            };
            dataGridView1.CellClick += (s, e) =>
            {
                eventCellClick?.Invoke(this, EventArgs.Empty);
            };
            cbGrade.SelectedIndexChanged += (s, e) =>
            {
                eventComboClick?.Invoke(this, EventArgs.Empty);
            };
        }

        public int StudentId 
        { 
            get => int.Parse(tbStudId.Text); 
            set => tbStudId.Text = value.ToString(); 
        }
        public string FirstName 
        { 
            get => tbFirstName.Text; 
            set => tbFirstName.Text = value; 
        }
        public string LastName 
        { 
            get => tbLastName.Text; 
            set => tbLastName.Text = value; 
        }
        public string DateOfBirth 
        { 
            get => dtpDob.Value.ToString("mm/dd/yyyy"); 
            set => dtpDob.Value = DateTime.Parse(value); 
        }
        public float Weight
        {
            get => float.Parse(tbWeight.Text);
            set => tbWeight.Text = value.ToString();
        }
        public int GradeId 
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public float Height 
        { 
            get => float.Parse(tbHeight.Text); 
            set => tbHeight.Text = value.ToString(); 
        }
        public string GradeName 
        { 
            get => cbGrade.SelectedItem.ToString(); 
            set => cbGrade.SelectedItem = value; 
        }

        public event EventHandler eventAdd;
        public event EventHandler eventUpdate;
        public event EventHandler eventDelete;
        public event EventHandler eventCellClick;
        public event EventHandler eventComboClick;

        public void GradeBind(BindingSource bindingSource)
        {
            cbGrade.DataSource = bindingSource;
        }

        public void StudentBind(BindingSource bindingSource)
        {
            dataGridView1.DataSource = bindingSource;
        }
    }
}
