using HotelMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.ViewModels
{
    public class ReservationFormViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [Required]
        public byte Room { get; set; }
            
        public ICollection<Rooms> Rooms { get; set; }
    }
}