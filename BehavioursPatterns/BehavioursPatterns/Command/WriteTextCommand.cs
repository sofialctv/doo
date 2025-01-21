using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Command
{
    public class WriteTextCommand : ICommand
    {
        private TextEditor _editor;
        private string _text;
        public WriteTextCommand(TextEditor editor, string text) { _editor = editor; _text = text; }
        public void Execute() { _editor.WriteText(_text); }
        public void Undo() { _editor.DeleteText(_text); }
    }
}
