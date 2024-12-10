namespace MainApp.Models;

public class Todo
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public bool IsCompleted { get; set; }
}
