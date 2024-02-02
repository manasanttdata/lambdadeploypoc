
using Microsoft.EntityFrameworkCore;
namespace TestWebAPI.Models
{
    //public class TodoContext
    
        public class TodoContext : DbContext
        {
            public TodoContext(DbContextOptions<TodoContext> options)
                : base(options)
            {
            }

            public DbSet<TodoItem> TodoItems { get; set; } = null!;
        }
    }

