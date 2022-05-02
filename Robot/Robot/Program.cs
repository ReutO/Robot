using System;
using System.Collections.Generic;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            //get order request

            var getOrderProcessor = Factory.PlaceOrder();
            var result = getOrderProcessor.Process();

            ///lets say he saved the order, now a robot needs to go to the kitchen and get it
            //and then another request to get order from table:
            var processOrderProcessor = Factory.GetProcessOrderProcessor();
            result = processOrderProcessor.Process(1);
        }
    }
}
