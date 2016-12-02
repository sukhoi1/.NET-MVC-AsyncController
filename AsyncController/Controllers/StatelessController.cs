using System.Web.Mvc;

namespace AsyncController.Controllers
{
    //[SessionState(SessionStateBehavior.Disabled)]
    public class StatelessController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Value = "ViewBag";
            Keep(TempData["Keep"]);

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult TempDataKeep()
        {
            TempData["Value"] = "TempData";
            TempData["Keep"] = true;
            return Redirect("Index");
        }

        public ActionResult TempDataState() //Can not be named TempData
        {
            TempData["Value"] = "TempData";
            TempData["Keep"] = false;
            return Redirect("Index");
        }

        public ActionResult SessionState() //Can not be named Session
        {
            Session["Value"] = "Session";
            Keep(TempData["Keep"]);

            return View("Index");
        }

        private void Keep(object keep)
        {
            if (keep is bool && (bool)keep == true)
            {
                // When should we call Keep?
                TempData.Keep();
            }
        }
    }
}