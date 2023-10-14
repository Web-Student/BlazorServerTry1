using System.ComponentModel.DataAnnotations;

namespace WiredBrainCoffeeBlazorServer.Data.Models;

public class Employee
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? FirstName { get; set; }
    [Required]
    [StringLength(50)]
    public string? LastName { get; set; }

    public bool IsDeveloper { get; set; }


    //So we can track which department an employee belongs to
    [Required]
    public int? DepartmentID { get; set; }
    
    public Department? Department { get; set; }
}
