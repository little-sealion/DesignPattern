using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.Email
{
    public class EmailClient
    {
        private List<IEmailProvider> _providers = new();
        public void AddProvider(IEmailProvider provider)
        {
            _providers.Add(provider);
        }

        public void DownloadEmails()
        {
            foreach (var provider in _providers)
            {
                provider.DownloadEmails();
            }
        }
    }
}