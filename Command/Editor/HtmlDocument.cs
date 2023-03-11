using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.Editor
{
    public class HtmlDocument
    {
        public string Content { get; set; } = null!;

        public void MakeBold()
        {
            Content = "<b>" + Content + "</b>";
        }
    }
}