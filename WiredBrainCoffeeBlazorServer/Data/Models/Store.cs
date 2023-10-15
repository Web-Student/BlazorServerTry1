using System.ComponentModel.DataAnnotations;

namespace WiredBrainCoffeeBlazorServer.Data.Models;

public class Store
{
    [Required]
    public int Id { get; set; }

    [Required] public string Name { get; set; }
    public string? Description { get;}

    public List<Department> DepartmentList { get; set; } = new();

}
