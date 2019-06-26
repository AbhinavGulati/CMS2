using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication3.Models
{
    public class TehsilModel
    {
       
        public int DistrictCode { get; set; }
        [Required]
        [Display(Name = "Tehsil Name")]
        public int TehsilCode { get; set; }
        public string TehsilName { get; set; }
    }
}
