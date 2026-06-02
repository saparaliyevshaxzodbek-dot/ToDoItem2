namespace ToDoList.Api.DTOs;

public class TodoSortDto
{
    public enum SortField
    {
        Title,
        Priority,
        CreatedAt,
        DueDate,
        IsCompleted
    }

    public SortField Field { get; set; } = SortField.CreatedAt;
    public SortDirection Direction { get; set; } = SortDirection.Descending;
}

public enum SortDirection
{
    Ascending = 0,
    Descending = 1
}
