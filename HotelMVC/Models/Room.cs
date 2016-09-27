using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelMVC.Models
{
    public class Room
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public byte Id { get; set; }
        public List<Amenity> Amenities { get; set; }
    }
}