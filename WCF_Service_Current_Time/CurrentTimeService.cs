using System;
using System.ServiceModel;

namespace WCF_Service_Current_Time
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CurrentTimeService : ICurrentTimeContract
    {
        public string GetTime() => DateTime.Now.ToString("hh:mm:ss");
    }
}
