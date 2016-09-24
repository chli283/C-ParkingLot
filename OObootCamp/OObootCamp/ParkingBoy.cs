using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OObootCamp
{
    public class ParkingBoy 
    {
        public ParkingLot lot1 = new ParkingLot();

        public ParkingBoy(ParkingLot lot)
        {
            lot1 = lot;
     
        }

        public int park(string car)
        {
            return lot1.park(car);
          
        }

        public string pick(int ticket)
        {
           return lot1.pick(ticket);
        }

    }
}
