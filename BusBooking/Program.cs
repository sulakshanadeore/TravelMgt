using BusBookingModels;
using ExceptionLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter courier ID");
        Courier courier = new Courier();
        try
        {
            courier.CourierID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter location of boarding");
            string loc = Console.ReadLine();
            PassengerBooking booking = new PassengerBooking();
            bool isAvailable = booking.FindName(loc);
            if (isAvailable)
            {
                Console.WriteLine("Yes available");
            }
            try
            {

                Location Passengerloc = new Location();
                Console.WriteLine("Enter LocID");
                Passengerloc.LocationID = Convert.ToInt32(Console.ReadLine());
            }
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Inner Catch.... ");
            //    Console.WriteLine(ex.Message);
            //}
            finally {
                Console.WriteLine("Inner finally invoked.......");
            }



            //else {
            //    Console.WriteLine("Not available");
            //}
        }
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Pls enter a valid courier number, ex:1233");

        //}
        catch (LocationNotFoundException ex)
        {
            Console.WriteLine(ex.Message);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Number is too long for our valid courier id");

        }
        finally {
            Console.WriteLine("Process Completed.....");


        }
        Console.Read();

    }
}