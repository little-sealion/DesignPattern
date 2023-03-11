using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    public abstract class BaseTask
    {
        private readonly AuditTrail _auditTrail;

        public BaseTask()
        {
            _auditTrail = new AuditTrail();
        }
        public void Execute()
        {
            _auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}