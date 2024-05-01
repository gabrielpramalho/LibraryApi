namespace LibraryApi.Communication.Requests;

public class RequestRegisterBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public int Supply { get; set; }
}
