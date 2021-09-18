using System;
using System.ServiceModel;

namespace WCF_Service_Current_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost server = new ServiceHost(typeof(CurrentTimeService));
            server.Open();
            Console.ReadLine();
            server.Close();
        }
    }
}
