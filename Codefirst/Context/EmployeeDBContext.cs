using Microsoft.EntityFrameworkCore;


namespace Codefirst.Context
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        { 
        
        }

        DbSet<Employee> Employees { get; set; }
    }
}
