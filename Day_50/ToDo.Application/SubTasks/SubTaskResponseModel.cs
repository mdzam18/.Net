using ToDo.Application.BaseEntities;

namespace ToDo.Application.SubTasks
{
    public class SubTaskResponseModel : BaseEntity
    {

        public string Title { get; set; }

        public int ToDoItemId { get; set; }

    }
}