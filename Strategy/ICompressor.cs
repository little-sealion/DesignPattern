using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public interface ICompressor
    {
        void Compress(string image);
    }
}