using System;

public interface INotificationService
{
    void SendNotification(string message);
}

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending email notification: {message}");
    }
}


public class SMSNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending SMS notification: {message}");
    }
}

// High level class that depends on INotificationService
public class NotificationManager
{
    private readonly INotificationService _notificationService;

    public NotificationManager(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void NotifyUser(string message)
    {
        _notificationService.SendNotification(message);
    }
}

// Example 
class Program
{
    static void Main()
    {
        INotificationService emailNotificationService = new EmailNotificationService();
        NotificationManager emailNotificationManager = new NotificationManager(emailNotificationService);

        // Sending email notification
        emailNotificationManager.NotifyUser("Your order has been shipped");

        INotificationService smsNotificationService = new SMSNotificationService();
        NotificationManager smsNotificationManager = new NotificationManager(smsNotificationService);

        // Sending SMS notification
        smsNotificationManager.NotifyUser("Meeting reminder");
    }
}