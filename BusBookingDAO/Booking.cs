﻿using BusBookingModels;
using ExceptionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBookingDAO
{
    public class Booking : IBookingService
    {
        
        public bool Book(PassengerBooking bookingReq)
        {

            //Code for accessing the database, or inputting any records to database
            //All database logic here
            //Access the number of seats available from the database for the said from and to locations
            //if availabe---book
            int bookingAvailable = 0;

            if (bookingAvailable == 0)
            {
                throw new BusFullException("No tickets available for the date");
            }
            return false;
        }
    }


    public class CourierUserServiceCollectionImpl : ICourierUserService
    {
        public void M1(int courierid)
        {
          //  throw new NotImplementedException();

        }

        public int placeOrder(Courier courierObj)
        {
            //insert data in the courier table

            
            return Courier.trackingNumber++;
        }
    }



}
