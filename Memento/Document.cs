using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    public class Document
    {
        public string Content { get; set; } = null!;
        public string FontName { get; set; } = null!;
        public string FontSize { get; set; } = null!;

        public override string ToString()
        {
            return $"Content:{Content},FontName:{FontName},FontSize:{FontSize}";
        }
    }
}