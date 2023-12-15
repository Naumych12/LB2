using Microsoft.EntityFrameworkCore;
using TaskManagement.Db;

namespace TaskManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            var optionsBuilder = new DbContextOptionsBuilder<TaskDbContext>();
            string connectionString = "Server=localhost;Database=task_management;Uid=root;Pwd=mysecretpassword;";
            ServerVersion serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
            var taskDbContext = new TaskDbContext(optionsBuilder.Options);
            
            Application.Run(new Form1(taskDbContext));
        }
    }
}