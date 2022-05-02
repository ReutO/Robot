using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public interface IAction<T>
    {
        bool Do(T action);
    }
}
