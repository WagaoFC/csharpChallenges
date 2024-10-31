using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Task 1",
                    Status = Communication.Enums.StatusType.concluida,
                },
                new ResponseShortTaskJson
                {
                    Id = 2,
                    Name = "Task 2",
                    Status = Communication.Enums.StatusType.aguardando,
                },
            }
        };
    }
}
