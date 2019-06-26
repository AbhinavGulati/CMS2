using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication3.Models
{
    public class VillageModel
    {
        public int CityCode { get; set; }
        
        [Display(Name = "Village Name")]
        public int VillageCode { get; set; }
        public string VillageName { get; set; }

        [Required]
        public int PoliceStation { get; set; }
        public int VillagePopulation { get; set; }

        public string VillageDescription { get; set; }



    }
}
