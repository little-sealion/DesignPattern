using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.WavFile
{
    public class WavFile
    {
        private List<ISegment> _segments = new();
        public void AddSegment(ISegment segment)
        {
            _segments.Add(segment);
        }

        public void Execute(IOperation operation)
        {
            foreach (var segment in _segments)
            {
                segment.Execute(operation);
            }
        }
    }
}