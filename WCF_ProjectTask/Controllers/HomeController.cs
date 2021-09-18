using System.ServiceModel;
using System.Web.Mvc;
using WCF_Service_Current_Time;

namespace WCF_ProjectTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var factory = new ChannelFactory<ICurrentTimeContract>(new BasicHttpBinding(),
                                                                   new EndpointAddress("http://localhost:9999/CurrentTimeService"));
            var channel = factory.CreateChannel();
            var result = channel?.GetTime();
            if (result != null)
            {
                ViewBag.Time = result;
            }
            return View();
        }
    }
}