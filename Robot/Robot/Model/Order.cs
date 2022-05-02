using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class Order
    {
        public int ID { get; set; }
        public Table Table { get; set; }
        public int PlaceOrderRobotID { get; set; }
        public int ReceivedOrderRobotID { get; set; }
        public int DinersAmount { get; set; }
        public decimal Total { get; set; }
        public ICollection<MenuItem>  MenuItems { get; set; }
    }
}
