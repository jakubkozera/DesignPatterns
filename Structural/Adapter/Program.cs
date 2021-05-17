using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            INotificationSender notificationSender = new SmsSenderAdapter();
            notificationSender.SendNotification(1, new Notification(){ Title = "Test", Body = "Body"});

        }
    }
}
