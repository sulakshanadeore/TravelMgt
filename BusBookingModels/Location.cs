using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ExceptionLibrary;
namespace BusBookingModels
{
    public class Location
    {
        private int _locationID;

        public int LocationID {
            get
            {
                return _locationID ;
            }
            set
            {


                if (value <= 0)
                {
                    throw new LocationNotFoundException("Enter a valid Location ID");

                }
                else
                {
                    _locationID = value;
                }


            }

        }
        public string LocationName { get; set; }
        public string Address { get; set; }
    }
}
