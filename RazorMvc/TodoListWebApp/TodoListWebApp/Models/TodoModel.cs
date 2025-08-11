using System.ComponentModel;

namespace TodoListWebApp.Models
{
    public class TodoModel
    {
        [DisplayName("Todo")]
        public string Todo { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }
    }
}
