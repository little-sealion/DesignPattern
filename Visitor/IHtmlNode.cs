using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}