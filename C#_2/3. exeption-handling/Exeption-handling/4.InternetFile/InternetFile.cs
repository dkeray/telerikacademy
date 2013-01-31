using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


class InternetFile
{
    static void Main()
    {
        string remoteUri = "http://www.devbg.org/img/Logo-BASD.jpg";
        string fileName = @"C:\Users\dkeray.DIDO\Desktop\logo.jpg", myStringWebResource = null;

        // Create a new WebClient instance.
        WebClient myWebClient = new WebClient();
     //   myStringWebResource = remoteUri + fileName;
        // Download the Web resource and save it into the current filesystem folder.

        try
        {
            myWebClient.DownloadFile(remoteUri, fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception cought!\n{0}:{1}", e.GetType().Name, e.Message);
            return;
        }
        Console.WriteLine("File downloaded!");
        finally
        {

        }

    }   
}
