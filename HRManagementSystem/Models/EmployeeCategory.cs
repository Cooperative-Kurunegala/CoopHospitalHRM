namespace HRManagementSystem.Models;

public class EmployeeCategory
{
    public int id { get; set; }
    public string categoryName { get; set; }
    public ICollection<Employee> employees { get; set; }
    
}