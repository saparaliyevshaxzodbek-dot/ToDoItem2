using ToDoList.Api.Entities;

namespace ToDoList.Api.Repositories;

public interface ITodoRepository
{
    Task<TodoItem> AddAsync(TodoItem todoItem);
    Task<IEnumerable<TodoItem>> GetAllAsync();
    Task<TodoItem?> GetByIdAsync(long id);
    Task<TodoItem> UpdateAsync(TodoItem todoItem);
    Task<bool> DeleteAsync(long id);
}