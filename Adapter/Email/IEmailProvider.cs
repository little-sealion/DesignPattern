using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.Email
{
    public interface IEmailProvider
    {
        void DownloadEmails();
    }
}