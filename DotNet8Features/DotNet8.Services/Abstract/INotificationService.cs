namespace DotNet8.Services.Abstract;

public interface INotificationService
{
    bool SendNotification(string message);
}