using System;
namespace DesignPattern.Proxy
{
    public class RouterProxy:Internet   
    {
        private Internet modem;
        private List<string> blackList = new List<string> { "movie", "game", "music", "fiction" };
        public RouterProxy()
        {
            modem = new Modem("123456");
        }

        public void httpAccess(string url)
        {
            foreach (var item in blackList)
            {
                if (url.Contains(item))
                {
                    Console.WriteLine("Access Denied");
                    return;
                } 
            }

            modem.httpAccess(url);
        }
    }
}

