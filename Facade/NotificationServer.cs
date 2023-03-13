using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class NotificationServer
    {
        // connect() -> Connection
        // authenticate(appID,key) -> authToken
        // Send(authToken,message,target)
        // conn.disconnect()

        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appID, string key)
        {
            return new AuthToken();
        }
        public void Send(AuthToken authToken, Message message, string target)
        {
            System.Console.WriteLine("Sending a message");
        }
    }
}