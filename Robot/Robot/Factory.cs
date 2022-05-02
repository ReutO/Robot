using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public static class Factory
    {
        public static IProcessor<bool> PlaceOrder()
        {
            return new ProcessRobot(
                getter: new RobotRepository(),
                action: new CompositeAction<Robot>(
                    new Walk(),
                    new Talk()));
        }

        public static IProcessor<bool, int> GetProcessOrderProcessor()
        {
            return new ProcessOrder(
                placeGetter: new PlaceRepository(),
                robotGetter: new RobotRepository(),
                action: new CompositeAction<Robot>(
                    new TakeOrder(),
                    new Walk()));//and more actions can be created here and in between without changing the code. And no duplicate code...
        }
    }
}
