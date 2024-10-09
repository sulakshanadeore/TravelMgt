using BusBookingModels;

namespace BusBookingDAO
{
    public interface IBookingService
    {
        bool Book(PassengerBooking bookingReq);


    }



    interface ICourierUserService
    {

        void M1(int courierid);
        int placeOrder(Courier courierObj);
    }
}
