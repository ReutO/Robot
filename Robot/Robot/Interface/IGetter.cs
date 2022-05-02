using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public interface IGetter<T>
    {
        T Get();
    }
    
    public interface IGetter<out T, in K>
    {
        T Get(K value);
    }
}
