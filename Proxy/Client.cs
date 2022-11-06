using System;
namespace DesignPattern.Proxy
{
    public class Client
    {
        public static void main()
        {
            Internet proxy = new RouterProxy();
            proxy.httpAccess("http://www.movie.com");
            proxy.httpAccess("http://www.game.com");

            proxy.httpAccess("ftp://www.study.com/java");
            proxy.httpAccess("http://www.work.com");
        }
    }
}

