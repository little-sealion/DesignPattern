using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class Library
    {
        private Dictionary<string, IEbook> _ebooks = new();
        public void Add(IEbook ebook)
        {
            if (!_ebooks.ContainsKey(ebook.FileName))
                _ebooks.Add(ebook.FileName, ebook);
        }
        public void OpenEbook(string fileName)
        {
            if (_ebooks.ContainsKey(fileName))
                _ebooks[fileName].Show();
        }
    }
}