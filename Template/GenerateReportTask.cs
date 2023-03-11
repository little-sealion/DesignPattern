using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    public sealed class GenerateReportTask : BaseTask
    {
        // when instantiate this class, it will invoke the default prameterless BaseTask Constructor
        protected override void DoExecute()
        {
            System.Console.WriteLine("Generating report");
        }
    }
}