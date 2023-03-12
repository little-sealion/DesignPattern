using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler _next;
        public Handler(Handler next)
        {
            _next = next;
        }
        public void Handle(HttpRequest request)
        {
            if (!DoHandle(request)) return;
            if (_next is not null)
                _next.Handle(request);
        }
        public abstract bool DoHandle(HttpRequest request);
    }
}