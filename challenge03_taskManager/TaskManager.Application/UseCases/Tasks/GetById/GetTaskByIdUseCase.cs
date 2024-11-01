using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = 1,
            Name = "Task 1",
            Description = "Description 1",
            Deadline = DateTime.Now,
            Priority = Communication.Enums.PriorityType.alta,
            Status = Communication.Enums.StatusType.aguardando,
        };
    }
}
