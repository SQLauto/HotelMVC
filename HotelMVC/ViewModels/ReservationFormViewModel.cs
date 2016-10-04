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
        public string ArrivalDateString { get; set; }

        [Required]
        [FutureDate]
        public string DepartureDateString { get; set; }

        [Required]
        public byte RoomId { get; set; }
            
        public ICollection<Rooms> Rooms { get; set; }

        public DateTime GetDepartureDate()
        {
            return DateTime.Parse(string.Format(DepartureDateString));
        }

        public DateTime GetArrivalDate()
        {
            return DateTime.Parse(string.Format(ArrivalDateString));
        }


    }
}