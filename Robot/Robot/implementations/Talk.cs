using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class Talk : IAction<Robot>
    {
        public bool Do(Robot value)
        {
            //get words from DB walk;
            return true;
        }
    }
}
