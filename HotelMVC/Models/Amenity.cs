using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public class Amenity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(1500)]
        public string Description { get; set; }

        public int Id { get; set; }
    }
}