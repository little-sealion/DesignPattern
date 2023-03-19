using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private string _data;
        private Singleton(string data)
        {
            _data = data;
        }

        public static Singleton GetInstance(string data)
        {
            lock (Singleton._instance)
            {
                if (_instance is null)
                {
                    _instance = new Singleton(data);
                }
            }

            return _instance;
        }
    }
}