using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace WebApplication3.Models
{ 
    public class DistrictModel
    {
        [Display(Name = "District Name")]
        [Required]
        public int DistrictCode { get; set; }
        public int TehsilCode { get; set; }

        public string DistrictName { get; set; }
        // public IEnumerable<SelectListItem> DistrictNames {get; set; }

    }
}
