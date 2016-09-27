using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public class Reservations
    {
        public int Id { get; set; }

        [Required]
        public Rooms Room { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }
    }
}