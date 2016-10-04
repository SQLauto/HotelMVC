using HotelMVC.Models;
using System.Collections.Generic;

namespace HotelMVC.ViewModels
{
    public class UserReservationsViewModel
    {
        public ICollection<Reservations> Reservations { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public string RoomName { get; set; }

    }
}