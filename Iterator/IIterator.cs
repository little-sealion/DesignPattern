using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.IIterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}