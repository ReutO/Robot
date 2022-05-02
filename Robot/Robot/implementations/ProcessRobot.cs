using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class ProcessRobot : IProcessor<bool>
    {
        private readonly IGetter<Robot> _getter;
        private readonly IAction<Robot> _action;
        public ProcessRobot(IGetter<Robot> getter, IAction<Robot> action)
        {
            _getter = getter;
            _action = action;
        }
        public bool Process()
        {
            var robot = _getter.Get();
            robot.IsBuissy = true;
            //Update DB in the same procedure maybe to Buissy
            return _action.Do(robot);
        }
    }
}
