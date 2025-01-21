using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Command
{
    public class TextEditor
    {
        private string _content = "";
        public void WriteText(string text) { _content += text; Console.WriteLine(_content); }
        public void DeleteText(string text) { _content = _content.Replace(text, ""); Console.WriteLine(_content); }
    }
}
