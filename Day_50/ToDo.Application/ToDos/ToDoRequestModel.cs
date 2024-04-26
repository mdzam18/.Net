using ToDo.Application.BaseEntities;
using ToDo.Application.SubTasks;

namespace ToDo.Application.ToDos
{
    public class ToDoRequestModel : BaseEntity
    {

        public string Title { get; set; }

        public string Status { get; set; }

        public DateTime TargetCompletionDate { get; set; }

        public int OwnerId { get; set; }

        public List<SubTaskRequestModel> SubTasks { get; set; }

    }
}