using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.Adapter.Email.Gmail;

namespace DesignPattern.Adapter.Email
{
    public class GmailAdapter : IEmailProvider
    {
        private GmailClient _gmailClient = new GmailClient();


        public void DownloadEmails()
        {
            _gmailClient.Connect();
            _gmailClient.GetEmails();
            _gmailClient.Disconnect();
        }
    }
}