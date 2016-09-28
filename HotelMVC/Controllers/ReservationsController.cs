using HotelMVC.Models;
using HotelMVC.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace HotelMVC.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new ReservationFormViewModel
            {
                Rooms = _context.Rooms.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(ReservationFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("Create", viewModel);

            var price = 50.00;

            var reservation = new Reservations
            {
                CustomerId = User.Identity.GetUserId(),
                RoomId = viewModel.Room,
                Price = price,
                ArrivalDate = viewModel.ArrivalDate,
                DepartureDate = viewModel.DepartureDate
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


    }
}