using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility
{
    public class WebServer
    {
        private Handler _firstHandler;

        public WebServer(Handler firstHandler)
        {
            _firstHandler = firstHandler;
        }

        public void Handle(HttpRequest request)
        {
            _firstHandler.Handle(request);
        }
    }
}