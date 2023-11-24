namespace GeneralApp.Services;

public interface IMessageNotifyService
{
    void Notify(string message);
}
public class MessageNotifyService : IMessageNotifyService
{
    public void Notify(string message)
    {
        Console.WriteLine($"New Message at {DateTime.Now} - {message}");
    }
}
