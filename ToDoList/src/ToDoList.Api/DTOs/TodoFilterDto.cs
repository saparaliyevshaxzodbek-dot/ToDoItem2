namespace ToDoList.Api.DTOs;

public class TodoFilterDto
{
    public string? Title { get; set; }
    public bool? IsCompleted { get; set; }
    public DateTime? DueDateFrom { get; set; }
    public DateTime? DueDateTo { get; set; }
    public int? Priority { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
