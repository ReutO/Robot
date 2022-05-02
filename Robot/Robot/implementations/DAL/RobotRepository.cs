using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class RobotRepository : IGetter<Robot>, IGetter<Robot, int>
    {

        public Robot Get()
        {
            //Goes to repository to finds not buissy robot

            return new Robot() { Place = new Place() { X = "123", Y = "123" }, IsBuissy = false };
        }

        public Robot Get(int orderID)
        {
            //do all this in the procedure
            
            var robot = new Robot() { 
                ID = 1, 
                IsBuissy = true,
                Order = new Order()
                {
                    ID = 1,
                    Table = new Table()
                    {
                        ID = 1,
                        Place = new Place() { ID = 1, X = "123", Y = "1234" }
                    },
                    DinersAmount = 3,
                    MenuItems = new List<MenuItem> { new MenuItem() { ID = 1, Name = "Omlet" } },
                    PlaceOrderRobotID = 2,
                    ReceivedOrderRobotID = 1,
                    Total = 40
                }};

            return robot;
        }
    }
}
