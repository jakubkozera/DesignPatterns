using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class AuthenticationManager
    {
        private INotificationSender _notificationSender;

        public AuthenticationManager(INotificationSender notificationSender)
        {
            this._notificationSender = notificationSender;
        }
        public void Authenticate(User user, string email, string password)
        {
            if (user.Email == email && user.Password == password)
            {
                _notificationSender.SendNotification(user);
            }
        }
    }
}
