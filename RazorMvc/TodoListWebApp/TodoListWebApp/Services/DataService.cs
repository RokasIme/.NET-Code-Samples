using TodoListWebApp.Models;

namespace TodoListWebApp.Services
{
    public class DataService
    {
        private List<TodoModel> _todos = new List<TodoModel>()
        {
            new TodoModel() { Todo = "Buy groceries", Description = "Milk, Bread, Eggs" },
            new TodoModel() { Todo = "Walk with wife", Description = "30 minutes in the forest" },
            new TodoModel() { Todo = "Finish code", Description = "Finish that app" }
        };

        public List<TodoModel> GetAllTodos()
        {
            return _todos;
        }

        public void AddTodo(TodoModel todo)
        {
            if (todo != null && !string.IsNullOrWhiteSpace(todo.Todo))
            {
                _todos.Add(todo);
            }
            else
            {
                throw new ArgumentException("Todo cannot be null or empty", nameof(todo));
            }
        }
    }
}
