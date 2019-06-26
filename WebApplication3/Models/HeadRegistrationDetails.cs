using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication3.Models
{
    public class HeadRegistrationDetails
    {
        [Required]
        [Display(Name = "Head Name")]
        public string HeadName { get; set; }
        [Required]
        [Display(Name = "Family Member in Your Family")]
        public int TotalfamilyMember { get; set; }
        [Required]
        [Display(Name = "Enter Age")]
        public int HeadAge { get; set; }

        [Required]
        public string HeadGender { get; set; }
        [Required]
        [Display(Name = "Enter your Address")]
        public string HeadAddress { get; set; }

        [Required]
        [Display(Name = "Enter Highest Education")]
        public string HeadHighestEducationDetails { get; set; }
  
        public string FamilyAilment { get; set; }
        [Required]
        [Display(Name = "Head Religion")]
        public string HeadReligion { get; set; }

         [Required]
        [Display(Name = "Head Caste")]
        public string HeadCaste { get; set; }
        [Required]
        [Display(Name = "Head Anunal Income")]
        public int HeadAnunalIncome { get; set; }
        
        public string HeadAdharCardNumber { get; set; }
        [Required]
        [Display(Name = "Mobile Number")] 
        public string HeadMobileNumber { get; set; }

        public string Martial_Status { get; set; }


    }
  
}
