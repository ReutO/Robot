using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public interface IProcessor<T>
    {
        T Process();
    }
    
    public interface IProcessor<out T, in K>
    {
        T Process(K value);
    }
}
