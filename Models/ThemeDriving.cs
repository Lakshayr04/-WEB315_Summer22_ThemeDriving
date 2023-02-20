using System;
using System.ComponentModel.DataAnnotations;

namespace _WEB315_Summer22_ThemeDriving.Models
{
    public class ThemeDriving
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CarModel { get; set; }

        public DateTime BookingDate { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Route { get; set; }
  
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string distance { get; set; }     

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string colour { get; set; }
        
        public int Price { get; set; }

        public int modelnumber { get; set; }
    }
}