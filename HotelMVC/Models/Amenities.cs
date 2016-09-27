using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public class Amenities
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Id { get; set; }
    }
}