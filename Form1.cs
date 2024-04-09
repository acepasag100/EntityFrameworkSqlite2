using EntityFrameworkSqlite2.Model;
using EntityFrameworkSqlite2.Presenter;
using EntityFrameworkSqlite2.Repositories;
using EntityFrameworkSqlite2.View;

namespace EntityFrameworkSqlite2
{
    public partial class Form1 : Form, StudentView
    {
        Repository repository = new Repository();
        public Form1()
        {
            InitializeComponent();
            Load += delegate
            {
                //dataGridView1.DataSource = repository.Students.ToList();
                StudentRepository repository = new StudentR();
                StudentPresenter presenter = new StudentPresenter(this, repository);
            };
            btnAdd.Click += delegate
            {
                eventAdd?.Invoke(this, EventArgs.Empty);
            };
        }

        public int StudentId 
        { 
            get => int.Parse(tbStudId.Text); 
            set => tbStudId.Text = value.ToString(); 
        }

        public event EventHandler eventAdd;

        public void StudentBind(BindingSource bindingSource)
        {
            dataGridView1.DataSource = bindingSource;
        }
    }
}
