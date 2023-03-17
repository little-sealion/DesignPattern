using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class EbookProxy : IEbook
    {
        private string _fileName;
        // create an ebook is expensive,need to load file from disk & save it to memory
        // so we only initialize it when needed
        private RealEbook? _ebook;

        public EbookProxy(string fileName)
        {
            _fileName = fileName;
        }

        public string FileName => _fileName;

        public void Show()
        {
            if (_ebook is null)
                _ebook = new RealEbook(_fileName);
            _ebook.Show();
        }
    }
}