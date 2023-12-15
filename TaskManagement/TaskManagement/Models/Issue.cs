using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models;

public class Issue
{
    [Key]
    public Guid Id { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public string Priority { get; set; }
    
    public Guid? EmployeeId { get; set; }
    public Employee Employee { get; set; }
    
    public Guid? ProjectId { get; set; }
    public Project Project { get; set; }
    public DateTime Created { get; set; }
}