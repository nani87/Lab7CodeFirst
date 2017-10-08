using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab4App.Models.Lab4
{
    public class City
    {
        public int CityId { get; set; }
        [Display(Name = "City Name")]
        public string CityName { get; set; }
        public int Population { get; set; }

        public string ProvinceCode { get; set; }
        public Province Province { get; set; }
    }
}