using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBookingModels
{
    public class Courier
    {
        int _courierid;
        public int CourierID
        {
            get
            {
                return _courierid;
            }
            set
            {


                if (value <=  0)
                {
                    Console.WriteLine("Not allowed");

                }
                else
                {
                    _courierid = value;
                }


            }
        }


        public DateOnly CourierDate { get; set; }


        public static int trackingNumber = 0;

    }
}
