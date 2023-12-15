using Microsoft.EntityFrameworkCore;
using TaskManagement.Db;

namespace TaskManagement
{
    public partial class Form1 : Form
    {
        private readonly TaskDbContext _taskDbContext;
        public Form1(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
            InitializeComponent();

            ShowIssues();
            ShowEmployees();
            ShowProjects();
        }

        public void ShowIssues()
        {
            tasksListView.Items.Clear();
            var issues = _taskDbContext.Issues.AsNoTracking()
                .Include(i => i.Employee)
                .Include(i => i.Project)
                .OrderByDescending(i => i.Created);

            foreach (var issue in issues)
            {
                ListViewItem item = new(issue.Id.ToString());
                item.SubItems.Add(issue.Summary);
                item.SubItems.Add(issue.Description);
                item.SubItems.Add(issue.Priority);
                item.SubItems.Add(issue.Employee?.Name);
                item.SubItems.Add(issue.Project?.Name);
                tasksListView.Items.Add(item);
            }
        }

        public void ShowProjects()
        {
            projectsListView.Items.Clear();
            var projects = _taskDbContext.Projects.AsNoTracking()
                .OrderByDescending(p => p.Name);

            foreach (var project in projects)
            {
                ListViewItem item = new(project.Id.ToString());
                item.SubItems.Add(project.Name);
                item.SubItems.Add(project.Client);
                item.SubItems.Add(project.Budget.ToString());
                projectsListView.Items.Add(item);
            }
        }

        public void ShowEmployees()
        {
            employeesListView.Items.Clear();
            var employees = _taskDbContext.Employees.AsNoTracking()
                .OrderByDescending(p => p.Name);

            foreach (var employee in employees)
            {
                ListViewItem item = new(employee.Id.ToString());
                item.SubItems.Add(employee.Name);
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.Phone);
                employeesListView.Items.Add(item);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            IssueForm issueForm = new(Guid.Empty, _taskDbContext);
            issueForm.Closed += (send, evt) => ShowIssues();
            issueForm.Show();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (tasksListView.SelectedItems.Count != 0)
            {
                var id = new Guid(tasksListView.SelectedItems[0].SubItems[0].Text);
                _taskDbContext.Remove(_taskDbContext.Issues.Find(id));
                _taskDbContext.SaveChanges();
                ShowIssues();
            }
        }

        private void tasksListView_ItemActivate(object sender, EventArgs e)
        {
            var id = new Guid((sender as ListView).SelectedItems[0].SubItems[0].Text);
            IssueForm issueForm = new(id, _taskDbContext);
            issueForm.Closed += (send, evt) => ShowIssues();
            issueForm.Show();
        }
    }
}