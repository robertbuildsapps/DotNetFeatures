using DotNet8.Services.Abstract;

namespace DotNet8.Services;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}

public class PushNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}

public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}