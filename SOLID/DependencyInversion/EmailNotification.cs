using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class EmailNotification : INotificationSender
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"Sending notification to user : {user.Name}");
        }
    }
}
