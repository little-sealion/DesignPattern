using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    public class EditorState
    {
        private readonly Document _document;
        public EditorState(Document document)
        {
            _document = document;
        }

        public Document GetContent()
        {
            return _document;
        }
    }
}