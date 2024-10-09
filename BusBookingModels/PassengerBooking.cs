using ExceptionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBookingModels
{
    public class PassengerBooking
    {
        //Collection Initializer
        Location[] validLocations = new Location[4] 
        {
        new Location{LocationID=1,LocationName="Pune",Address="Pimpri" },
        new Location{LocationID=2,LocationName="Chennai",Address="ABC" },
        new Location{LocationID=3,LocationName="Bangalore", Address="RajajiNagar" },
        new Location{LocationID=4,LocationName="Mumbai",Address="Thane" }
       };


        public bool FindName(string name)
        {

            string[] locs = new string[4];
            locs[0] = "Pune";
            locs[1] = "Chennai";
            locs[2] = "Bangalore";
            locs[3] = "Mumbai";


            bool isthere = false;
            for (int i = 0; i < locs.Length; i++)
            {
                if (locs[i] == name)
                {
                    isthere = true;        
                }
                
            }

            if (!isthere)
            {
                throw new LocationNotFoundException("Location Invalid.. You cannot board from this point");
            }
            return isthere ;


        }
            
                 
            

               
            
            
        
        
        //seats> 0
        public int NoOfSeats { get; set; }

        //fromloc
        public string FromLocation { get; set; }

        //toloc
        public string ToLocation { get; set; }
    }
}
