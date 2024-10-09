using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BusBooking
{
    internal class FileWorking
    {
        static void Main(string[] args)
        {
            //Static Methods &  Instance Methods

            //File.WriteAllText(@"C:\Users\hp\Desktop\file3.txt", "this is a demo file");
            //File.Delete(@"C:\Users\hp\Desktop\file2.txt");

            //Directory.CreateDirectory(@"C:\Users\hp\Desktop\Dir1");
            //Directory.Delete(@"C:\Users\hp\Desktop\Dir1");

            //DriveInfo.
            Console.WriteLine("1. for text file, 5. for reading text file,  2. binary 3. xml 4. json");
            int filetype=Convert.ToInt32(Console.ReadLine());
            switch (filetype)
            {
                case 1:
                    FileStream fs = null;
                    StreamWriter w = null;
                    try
                    {
                 fs = new FileStream("resumefile.txt", FileMode.CreateNew, FileAccess.Write);
                 w = new StreamWriter(fs);
                 w.Write("HEllo Here.....Welcome ......sdfkjskjfjksfsfskjdfhjdbfhjsdbfhshfgshgfh" +
                 "kjhdskjfhskjfhjkfkjskfkjshfkjkjfskjfkjsfhkjsjfkshfhklfshksjfksdfhhsjdfhkjshfkjsdfjsdfjsjfs" +
                 "jkdbfkjshfjkskfjdskfjkshfkshfkshjhfjsfhj");

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        w.Flush();
                        w.Close();
                        w.Dispose();

                        fs.Close();
                        fs.Dispose();
                    }

                       


                    break;

                case 5:
                    FileStream fs1 = new FileStream("Logger.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr=new StreamReader(fs1);
                    Console.WriteLine(sr.ReadToEnd());
                    
                    sr.Close();
                    fs1.Close ();

                    


                    break;

                    case 2:
                        break;
                    case 3:
                    break;
                    case 4:
                        break;
                        
                default:
                    break;
            }





            Console.Read();




        }
    }
}
