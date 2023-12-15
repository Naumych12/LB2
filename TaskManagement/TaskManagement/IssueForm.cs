using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Db;
using TaskManagement.Models;

namespace TaskManagement
{
    public partial class IssueForm : Form
    {
        private readonly TaskDbContext _taskDbContext;
        private Issue _issue = new();
        
        
        public IssueForm(Guid id, TaskDbContext taskDbContext)
        {
            InitializeComponent();

            _taskDbContext = taskDbContext;
            
            var employees = _taskDbContext.Employees.OrderByDescending(x => x.Name).ToList();
            var projects = _taskDbContext.Projects.OrderByDescending(x => x.Name).ToList();
            
            employeesCb.DataSource = employees;
            projectsCb.DataSource = projects;
            employeesCb.ValueMember = "Id";
            projectsCb.ValueMember = "Id";
            employeesCb.DisplayMember = "Name";
            projectsCb.DisplayMember = "Name";
            employeesCb.SelectedIndex = -1;
            projectsCb.SelectedIndex = -1;

            if (id == Guid.Empty)
            {
                return;
            }
            
            _issue = _taskDbContext.Issues.AsNoTracking()
                .Include(i => i.Employee)
                .Include(i => i.Project)
                .FirstOrDefault(x => x.Id == id);
            
            employeesCb.SelectedIndex = employees.FindIndex(x => x.Id == _issue.EmployeeId);
            projectsCb.SelectedIndex = projects.FindIndex(x => x.Id == _issue.ProjectId);
            
            summaryTb.Text = _issue!.Summary;
            descriptionTb.Text = _issue.Description;
            priorityTb.Text = _issue.Priority;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _issue.Summary = summaryTb.Text;
            _issue.Description = descriptionTb.Text;
            _issue.Priority = priorityTb.Text;
            
            var employees = _taskDbContext.Employees.OrderByDescending(x => x.Name).ToList();
            var projects = _taskDbContext.Projects.OrderByDescending(x => x.Name).ToList();

            if (employees.Count != 0 && employeesCb.SelectedIndex != -1)
            {
                _issue.Employee = employees[employeesCb.SelectedIndex];
            }
            
            if (projects.Count != 0 && projectsCb.SelectedIndex != -1)
            {
                _issue.Project = projects[projectsCb.SelectedIndex];
            }

            if (_issue.Id == Guid.Empty)
            {
                _issue.Id = Guid.NewGuid();
                _issue.Created = DateTime.Now;
                _taskDbContext.Add(_issue);
            }
            else
            {
                _taskDbContext.Update(_issue);
            }

            _taskDbContext.SaveChanges();
            Close();
        }
    }
}
