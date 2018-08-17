using System.Configuration;
using System.Net.Http;
using System.Web.Mvc;
using CroweTest.Models;

namespace CroweTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MessageToWorldModel model = null;
            var client = new HttpClient();
            var path = "http://localhost:60562/api/MessageToWorldApi/";
            var response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                model = response.Content.ReadAsAsync<MessageToWorldModel>().Result;
            }
            else
            {
                model = new MessageToWorldModel(){Message = ConfigurationManager.AppSettings["DefaultHelloWorldMessage"] };
            }
            return View(model);
        }
    }
}
