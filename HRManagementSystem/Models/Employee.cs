namespace HRManagementSystem.Models;

public class Employee
{
    public int id { get; set; }
    public string fullName { get; set; }
    public string nic { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string designation { get; set; }
    public string department { get; set; }
    public string epfNumber { get; set; }
    public string etfumber { get; set; }
    public DateTime dateOfJoining { get; set; }
    public string workSchedule { get; set; }
    
    public int? employeeCategoryId { get; set; }
    public EmployeeCategory employeeCategory { get; set; }
}