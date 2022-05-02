using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class TakeOrder : IAction<Robot>
    {
        public bool Do(Robot robot)
        {
            //take plate;
            robot.Place = robot.Order.Table.Place;

            return true;
        }
    }
}
