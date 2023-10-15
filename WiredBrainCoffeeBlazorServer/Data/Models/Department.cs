using System.ComponentModel.DataAnnotations;

namespace WiredBrainCoffeeBlazorServer.Data.Models;

public class Department
{
    public int ID { get; set; }
    [Required]
    [StringLength(50)]
    public string? Name { get; set; }

    public int? StoreID { get; set; }

    //to let us access employees in each department
    public List<Employee> Employees { get; set; } = new();
}
