using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication3.Models
{
    public class CityModel
    {
        public int TehsilCode { get; set; }

        [Display(Name = "City Name")]
        public int CityCode { get; set; }
        public string CityName { get; set; }
        public int CityPoliceStation { get; set; }
        public int  CityPopulation { get; set; }

        public string CityDescription { get; set; }
    }
}
