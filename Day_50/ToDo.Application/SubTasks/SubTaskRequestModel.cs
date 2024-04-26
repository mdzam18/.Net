using ToDo.Application.BaseEntities;

namespace ToDo.Application.SubTasks
{
    public class SubTaskRequestModel : BaseEntity
    {

        public string Title { get; set; }

        public int ToDoItemId { get; set; }

    }
}
