using Microsoft.EntityFrameworkCore;
using WiredBrainCoffeeBlazorServer.Data.Models;

namespace WiredBrainCoffeeBlazorServer.Data;

public class EmployeeManagerDBContext : DbContext
{
    public EmployeeManagerDBContext(DbContextOptions<EmployeeManagerDBContext> options) : base(options) { }
    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<Department> Departments => Set<Department>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Department>().HasData(
            new Department { ID = 1, Name = "Finances" },
            new Department { ID = 2, Name = "Sales" },
            new Department { ID = 3, Name = "Marketing" },
            new Department { ID = 4, Name = "Human Resources" },
            new Department { ID = 5, Name = "IT" },
            new Department { ID = 10, Name = "Joke Creation and Management" });

        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, FirstName = "Anna", LastName = "Rockstar", DepartmentID = 2 },
            new Employee { Id = 2, FirstName = "Julia", LastName = "Developer", DepartmentID = 5, IsDeveloper = true },
            new Employee { Id = 3, FirstName = "Mary", LastName = "Poppins", DepartmentID = 10 },
            new Employee { Id = 4, FirstName = "Mary Jane", LastName = "Parker", DepartmentID = 2, IsDeveloper = true },
            new Employee { Id = 5, FirstName = "Bob", LastName = "Poppins", DepartmentID = 4 },
            new Employee { Id = 6, FirstName = "J. Ava", LastName = "Script", DepartmentID = 10 , IsDeveloper = true},
            new Employee { Id = 7, FirstName = "C. ", LastName = "Sharp", DepartmentID = 10, IsDeveloper = true },
            new Employee { Id = 8, FirstName = "C", LastName = "Plus Plus", DepartmentID = 1, IsDeveloper = true },
            new Employee { Id = 9, FirstName = "Blazor", LastName = "Server Jr", DepartmentID = 5, IsDeveloper = true },
            new Employee { Id = 10, FirstName = "Monty", LastName = "Python", DepartmentID = 5, IsDeveloper = false }) ;
    }
}
