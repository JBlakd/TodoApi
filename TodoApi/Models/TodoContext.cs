using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        { 
        }

        // null forgiving operator to the compiler: "this isn't null, trust me"
        // prevents the compiler from issuing a warning for a possible null reference
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
