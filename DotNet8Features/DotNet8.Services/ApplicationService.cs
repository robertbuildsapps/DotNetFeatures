using DotNet8.Services.Abstract;

namespace DotNet8.Services;

public class ApplicationService : IApplicationService
{
    public bool SendMessage(
        INotificationService notificationService,
        string message)
    {
        return notificationService.SendNotification(message);
    }
}