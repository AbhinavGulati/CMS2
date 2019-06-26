using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication3.Models
{
    public class ChildRegistrationDetails
    {
        [Display(Name = "Child Name")]
        public string ChildName { get; set; }

        [Display(Name = "Child Occupation")]
        public string ChildOccupation { get; set; }

        [Display(Name = "Enter Age")]
        public int ChildAge { get; set; }
        [Display(Name = "Gender")]
        public string ChildGender { get; set; }

        [Display(Name = "Relation With Head")]
        public string ChildRelation { get; set; }

        [Display(Name = "Living Since")]

        public string ChildLivingSince { get; set; }


        [Display(Name = "Enter Highest Education")]
        public string ChildHighestEducationDetails { get; set; }

        [Display(Name = "Family Ailment")]

        public string ChildFamilyAilment { get; set; }

        [Display(Name = "Child Religion")]
        public string ChildReligion { get; set; }

        [Display(Name = "Remarks if Any")]
        public string ChildRemarks { get; set; }

        [Display(Name = "Enter Adhar Card Number")]
        public string ChildAdharCardNumber { get; set; }

        [Display(Name = "Mobile Number")]
        public string ChildMobileNumber { get; set; }
    }
}
