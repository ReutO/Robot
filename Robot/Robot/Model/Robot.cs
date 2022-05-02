using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class Robot
    {
        public int ID { get; set; }
        public Place Place { get; set; }
        public bool IsBuissy { get; set; }
        public Order Order { get; set; }
    }
}
