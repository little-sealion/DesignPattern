using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public interface ITravelMode
    {
        float GetETA();
        int GetDirection();

    }
}