//第13天依赖注入
public class TodoService{
    public List<string> Tasks { get; set; } = new();
    public void AddTask(string task) => Tasks.Add(task);
}