using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> _nodes = new();
        public void AddNode(IHtmlNode node)
        {
            _nodes.Add(node);
        }
        public void Execute(IOperation operation)
        {
            foreach (var node in _nodes)
            {
                node.Execute(operation);
            }
        }
    }
}