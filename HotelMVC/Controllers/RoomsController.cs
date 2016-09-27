using System.Web.Mvc;

namespace HotelMVC.Controllers
{
    public class RoomsController : Controller
    {
        // GET: Rooms
        public ActionResult List()
        {
            return View();
        }
    }
}