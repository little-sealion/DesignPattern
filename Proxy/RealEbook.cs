using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{

    public class RealEbook : IEbook
    {
        public string FileName { get; private set; }

        public RealEbook(string fileName)
        {
            FileName = fileName;
            load();
        }

        private void load()
        {
            System.Console.WriteLine("Loading the ebook " + FileName);
        }

        public void Show()
        {
            System.Console.WriteLine("Showing the ebook " + FileName);
        }

    }
}