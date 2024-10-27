using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;

public class RequestTaskJson
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string description { get; set; } = string.Empty;
    public PriorityType priority { get; set; }
    public DateTime deadline { get; set; }
    public StatusType status { get; set; }
}
