using DotNet8.Services.Abstract;

namespace DotNet8.Services;

public class EmailNotificationService : INotificationService
{
    public bool SendNotification(string message)
    {
        Console.WriteLine(message);
        return true;
    }
}

public class PushNotificationService : INotificationService
{
    public bool SendNotification(string message)
    {
        Console.WriteLine(message);
        return true;
    }
}

public class SmsNotificationService : INotificationService
{
    public bool SendNotification(string message)
    {
        Console.WriteLine(message);
        return true;
    }
}