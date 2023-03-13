using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class EncryptedCloudStream : IStream
    {
        private IStream _stream;

        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var encryptedData = encrypt(data);
            _stream.Write(encryptedData);
        }

        private string encrypt(string data)
        {
            return "#@&8$#%" + data + "#@&8$#%";
        }
    }
}