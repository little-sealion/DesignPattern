using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DataReader
{
    public abstract class DataReader
    {
        private DataReader _next;
        public void SetNext(DataReader next)
        {
            _next = next;
        }

        public void Read(File file)
        {
            if (file.Extension == GetExtension())
            {
                DoRead(file);
                return;
            }
            if (_next is not null)
            {
                _next.Read(file);
            }
            else
            {
                throw new Exception("Unsupported format");
            }
        }

        protected abstract string GetExtension();
        protected abstract void DoRead(File file);
    }
}