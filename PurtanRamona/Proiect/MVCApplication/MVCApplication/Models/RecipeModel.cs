using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class RecipeModel
    {   
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give the first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give the last name.")]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "You need to give the age.")]
        public int Age { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "You need to give the address")]
        public string Address { get; set; }

        [Display(Name = "Medical Records")]
        [Required(ErrorMessage = "You need to give the medical records")]
        public int MedicalRecords { get; set; }
        
        [Display(Name = "Diagnostic")]
        [Required(ErrorMessage = "You need to give the diagnostic")]
        [DataType(DataType.MultilineText)]
        public string Diagnostic { get; set; }

        [Display(Name = "Prescriptions")]
        [Required(ErrorMessage = "You need to give the prescriptions")]
        [DataType(DataType.MultilineText)]
        public string Prescriptions { get; set; }
    }
}