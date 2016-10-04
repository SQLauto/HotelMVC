using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public class Reservations
    {
        public int Id { get; set; }

        public Rooms Room { get; set; }

        [Required]
        public byte RoomId { get; set; }

        [Required]
        public DateTime ArrivalDate { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        public double Price { get; set; }

        public ApplicationUser Customer { get; set; }

        [Required]
        public string CustomerId { get; set; }
    }
}