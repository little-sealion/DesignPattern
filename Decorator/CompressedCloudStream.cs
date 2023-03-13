using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class CompressedCloudStream : IStream
    {
        private IStream _stream;

        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var compressedData = compress(data);
            _stream.Write(compressedData);
        }

        private string compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}