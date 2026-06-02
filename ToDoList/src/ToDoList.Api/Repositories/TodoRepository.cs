using Microsoft.EntityFrameworkCore;
using ToDoList.Api.Data;
using ToDoList.Api.Entities;

namespace ToDoList.Api.Repositories;

public class TodoRepository : ITodoRepository
{
    private readonly AppDbContext _context;

    public TodoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<TodoItem> AddAsync(TodoItem todoItem)
    {
        todoItem.CreatedAt = DateTime.UtcNow;
        await _context.TodoItems.AddAsync(todoItem);
        await _context.SaveChangesAsync();
        return todoItem;
    }

    public async Task<IEnumerable<TodoItem>> GetAllAsync()
    {
        return await _context.TodoItems.ToListAsync();
    }

    public async Task<TodoItem?> GetByIdAsync(long id)
    {
        return await _context.TodoItems.FirstOrDefaultAsync(t => t.TodoItemId == id);
    }

    public async Task<TodoItem> UpdateAsync(TodoItem todoItem)
    {
        todoItem.UpdatedAt = DateTime.UtcNow;
        _context.TodoItems.Update(todoItem);
        await _context.SaveChangesAsync();
        return todoItem;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var todoItem = await _context.TodoItems.FirstOrDefaultAsync(t => t.TodoItemId == id);
        if (todoItem == null)
            return false;

        _context.TodoItems.Remove(todoItem);
        await _context.SaveChangesAsync();
        return true;
    }
}
