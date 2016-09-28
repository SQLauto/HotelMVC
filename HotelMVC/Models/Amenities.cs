using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public class Amenities
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Id { get; set; }

        public ICollection<Rooms> Rooms { get; set; }
    }
}