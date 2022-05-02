using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class Walk : IAction<Robot>
    {
        public bool Do(Robot value)
        {
            //do walk, update new place maybe
            return true;
        }
    }
}
