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
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid last name")]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Age required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid age")]
        [Range(0, 130)]
        public int Age { get; set; }

        [Display(Name = "Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address required")]
        public string Address { get; set; }

        [Display(Name = "Medical Records")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Medical records")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid medical records")]
        public int MedicalRecords { get; set; }

        [Display(Name = "Diagnostic")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Diagnostic required")]
        [DataType(DataType.MultilineText)]
        public string Diagnostic { get; set; }

        [Display(Name = "Prescriptions")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Prescriptions required")]
        [DataType(DataType.MultilineText)]
        public string Prescriptions { get; set; }
    }
}