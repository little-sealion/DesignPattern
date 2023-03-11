using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    public class History
    {
        private Stack<EditorState> states = new();
        private readonly Document emptyDocument = new Document { Content = "None", FontName = "None", FontSize = "None" };
        public void Push(EditorState state)
        {
            states.Push(state);
        }

        public EditorState Pop()
        {
            if (states.Count > 0)
                return states.Pop();
            else
            {
                return new EditorState(emptyDocument);
            }
        }

    }
}