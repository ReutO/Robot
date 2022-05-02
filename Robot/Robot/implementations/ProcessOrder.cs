using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class ProcessOrder : IProcessor<bool, int>
    {
        private readonly IGetter<Place, int> _placeGetter;
        private readonly IAction<Robot> _action;
        private readonly IGetter<Robot, int> _robotGetter;
        public ProcessOrder(IGetter<Place, int> placeGetter, IGetter<Robot, int> robotGetter, IAction<Robot> action)
        {
            _robotGetter = robotGetter;
            _placeGetter = placeGetter;
            _action = action;
        }

        public bool Process(int id)
        {
            var robot = _robotGetter.Get(id);

            var kitchenPlace = _placeGetter.Get(1); //kitchetID - might be an enum with cache
            robot.Place = kitchenPlace;

            return _action.Do(robot);

        }
    }
}
