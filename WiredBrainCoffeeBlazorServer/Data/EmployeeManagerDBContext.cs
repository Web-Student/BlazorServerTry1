using Microsoft.EntityFrameworkCore;
using WiredBrainCoffeeBlazorServer.Data.Models;

namespace WiredBrainCoffeeBlazorServer.Data;

public class EmployeeManagerDBContext : DbContext
{
    public EmployeeManagerDBContext(DbContextOptions<EmployeeManagerDBContext> options) : base(options) { }
    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<Department> Departments => Set<Department>();

}
