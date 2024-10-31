using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestRegisterTaskJson request)
    {
        return new ResponseRegisteredTaskJson
        {
            id = 7,
            task = request.name,
        };
    }
}
