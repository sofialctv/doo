using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.TemplateMethod
{
    public abstract class ReportGenerator
    {
        public void GenerateReport() { Console.WriteLine("Generating report header..."); Export(); }
        protected abstract void Export();
    }
}
