using System;
namespace DesignPattern.Proxy
{
    public class Switch : Intranet
    {
        public void fileAccess(string path)
        {
            Console.WriteLine("Visting intranet: "+path);
        }
    }

}

