using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class PlaceRepository : IGetter<Place, int>
    {

        public Place Get(int id)
        {
            //Goes to DB

            return new Place() { X = "123", Y = "123" };
        }
    }
}
