using Microsoft.EntityFrameworkCore;
using todoonboard_api.Models;


namespace todoonboard_api.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<Board> Board { get; set; }

        public DbSet<User> Users { get; set; } = null!;
    }
}