using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OObootCamp
{
    public class ParkingLot
    {
        public static List<string> lot = new List<string>();

        public int park(string car)
        {
           
           lot.Add(car);
            return lot.IndexOf(car);
        }

        public string pick(int ticket)
        {
            return lot[ticket];

        }
    }
}
