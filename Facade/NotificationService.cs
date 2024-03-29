using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("appID", "key");
            server.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}