namespace DotNet8.Services.Abstract;

public interface IApplicationService
{
    bool SendMessage(INotificationService notificationService, string message);
}