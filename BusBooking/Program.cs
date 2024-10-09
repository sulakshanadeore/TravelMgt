using BusBookingModels;
using ExceptionLibrary;

internal class Program
{
    private static void Main(string[] args)
    {

        Location l=new Location();
        l.LocationID = 11;
        l.LocationName = "sfs";
        l.Address = "Pune";


        Location l2 = new Location {LocationID=1,LocationName="Edens Garden,1st floor",Address="Mumbai" };
        Console.WriteLine(l2.LocationID);
        Console.WriteLine(l2.LocationName);
        Console.WriteLine(l2.Address);

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
            FileStream fs=new FileStream("Logger.txt",FileMode.CreateNew,FileAccess.Write);
            StreamWriter sw=new StreamWriter(fs);
        
            
            sw.WriteLine(ex.Message);
            sw.WriteLine("Source=" + ex.Source);
            sw.WriteLine(ex.StackTrace);
            sw.Close();
            fs.Close();
            sw.Dispose();
            fs.Dispose();


           



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