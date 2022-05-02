using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class CompositeAction<T> : IAction<T>
    {
        private readonly IAction<T>[] _actions;

        public CompositeAction(params IAction<T>[] actions)
        {
            _actions = actions;
        }
        public bool Do(T value)
        {
            foreach (var action in _actions)
            {
                if (!action.Do(value))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
