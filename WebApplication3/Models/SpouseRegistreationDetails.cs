using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication3.Models
{
    public class SpouseRegistreationDetails
    {
        [Display(Name = "Spouse Name")]
        public string SpouseName { get; set; }
        
        [Display(Name = "Spouse Occupation")]
        public string SpouseOccupation { get; set; }
      
        [Display(Name = "Enter Age")]
        public int SpouseAge { get; set; }

        
        public string SpouseGender { get; set; }
      
        [Display(Name = "Spouse Relation")]
        public string SpouseRelation { get; set; }

        [Display(Name = "Living Since")]
        public string SpouseLivingSince { get; set; }


        [Display(Name = "Enter Highest Education")]
        public string SpouseHighestEducationDetails { get; set; }

        public string SpouseFamilyAilment { get; set; }
        
        [Display(Name = "Spouse Religion")]
        public string SpouseReligion { get; set; }
                     
        [Display(Name = "Remarks if Any")]
        public string SpouseRemarks { get; set; }

        public string SpouseAdharCardNumber { get; set; }
     
        [Display(Name = "Mobile Number")]
        public string SpouseMobileNumber { get; set; }

        public string Child { get; set; }
    }
}
