namespace bookstoreManagement.Communication.Requests;

public class RequestRegisteredBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public float Price { get; set; }
    public int Quantity { get; set; }
}
