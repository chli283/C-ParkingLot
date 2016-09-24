using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace OObootCamp
{
    public class ParkingLot
    {
        public static List<string> lot = new List<string>();
        public int max = 0;

        public ParkingLot(int count)
        {
            this.max = count;
        }

        public ParkingLot()
        {
            max = 100;
        }

        public int park(string car)
        {
            if (max > 0)
            {
                lot.Add(car);
                max--;
                return lot.IndexOf(car);
            }
            else
            {
                throw new Exception("Full"); 
            }
    
        }

        public string pick(int ticket)
        {
            string car =  lot[ticket];
            lot[ticket] = null;
            max++;
            return car;

        }
    }
}
