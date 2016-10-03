using HotelMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.ViewModels
{
    public class ReservationFormViewModel
    {
        [Required]
        [FutureDate]
        public DateTime ArrivalDate { get; set; }

        [Required]
        [FutureDate]
        public DateTime DepartureDate { get; set; }

        [Required]
        public byte Room { get; set; }
            
        public ICollection<Rooms> Rooms { get; set; }
    }
}