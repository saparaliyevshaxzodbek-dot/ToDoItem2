using Microsoft.EntityFrameworkCore;
using ToDoList.Api.Entities;

namespace ToDoList.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; }
}
