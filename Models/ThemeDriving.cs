using System;
using System.ComponentModel.DataAnnotations;

namespace _WEB315_Summer22_ThemeDriving.Models
{
    public class ThemeDriving
    {
        public int ID { get; set; }
        public string CarModel { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        public string Route { get; set; }
        public decimal Price { get; set; }
        public string distance { get; set; }

        /*public int Rating { get; set;}
        public string RelatedFilms {get; set;}*/
    }
}