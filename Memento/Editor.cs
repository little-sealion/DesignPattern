using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    public class Editor
    {
        public Document Document { get; private set; } = null!;

        public EditorState CreateState()
        {
            return new EditorState(Document);
        }
        public void Restore(EditorState state)
        {
            Document = state.GetContent();
        }
        public void SetContent(Document document)
        {
            Document = document;
        }
    }
}