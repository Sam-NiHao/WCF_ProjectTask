using System.ServiceModel;

namespace WCF_Service_Current_Time
{
    [ServiceContract]
    public interface ICurrentTimeContract
    {
        [OperationContract]
        string GetTime();
    }
}
