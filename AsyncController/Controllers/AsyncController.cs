using System.Threading.Tasks;
using System.Web.Mvc;
using AsyncController.Service;

namespace AsyncController.Controllers
{
    public class AsyncHomeController : System.Web.Mvc.AsyncController
    {
        public async Task<ActionResult> Index()
        {
            string data = await Task<string>.Factory.StartNew(() =>
            {
                return new RemoteService().GetRemoteData();
            });

            return View((object)data);
        }

        public async Task<ActionResult> Index2()
        {
            string data = await new RemoteService().GetRemoteDataAsync();
            return View((object)data);
        }
    }
}