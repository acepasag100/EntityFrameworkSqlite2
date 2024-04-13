using EntityFrameworkSqlite2.Model;
using EntityFrameworkSqlite2.Presenter;
using EntityFrameworkSqlite2.Repositories;
using EntityFrameworkSqlite2.View;

namespace EntityFrameworkSqlite2
{
    public partial class Form1 : Form, StudentView, GradeView, StudentAdressView
    {
        Repository repository = new Repository();
        public Form1()
        {
            InitializeComponent();
            Load += delegate
            {
                StudentRepository repository = new StudentR();
                GradeRepository gradeRepository = new GradeR();
                StudentAddressRepository studentAddressRepository = new StudentAddressR();
                StudentPresenter presenter = new StudentPresenter(this, repository, gradeRepository, studentAddressRepository);
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
            get => dtpDob.Value.ToString("dd-MM-yyyy"); 
            set => dtpDob.Value = DateTime.Parse(value); 
        }
        public float Weight
        {
            get => float.Parse(tbWeight.Text);
            set => tbWeight.Text = value.ToString();
        }
        public int GradeId 
        {
            get => int.Parse(cbGrade.Tag.ToString()); 
            set => cbGrade.Tag = value.ToString(); 
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
        public int StudentAddressId 
        { 
            get => int.Parse(tbStudAddId.Text); 
            set => tbStudAddId.Text = value.ToString(); 
        }
        public string Address 
        { 
            get => tbAddress.Text;
            set => tbAddress.Text = value; 
        }
        public string City 
        { 
            get => tbCity.Text; 
            set => tbCity.Text = value; 
        }
        public string State 
        { 
            get => tbState.Text; 
            set => tbState.Text = value; 
        }
        public string Country 
        { 
            get => tbCountry.Text; 
            set => tbCountry.Text = value; 
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
            bindingSource.DataSourceChanged += delegate
            {
                if (bindingSource.Count > 0)
                {
                    dataGridView1.Columns["StudentId"].Visible = false;
                    dataGridView1.Columns["Grade"].Visible = false;
                    dataGridView1.Columns["GradeId"].Visible = false;
                    dataGridView1.Columns["StudentAddress"].Visible = false;
                }
            };
        }
    }
}
