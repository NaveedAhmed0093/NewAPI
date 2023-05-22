using API_CRM.Model;
using Microsoft.EntityFrameworkCore;

namespace API_CRM.Model
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
