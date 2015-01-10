using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using EFMVC.Web.Helpers;

namespace EFMVC.Web.ViewModels
{
    public class PostProfileFormModel
    {       
        public int ProfileId { get; set; }
        public IEnumerable<SelectListItem> User { get; set; }        
        public IEnumerable<SelectListItem> Designation { get; set; }
        public IEnumerable<SelectListItem> Location { get; set; }
        
        [Required(ErrorMessage="Headline Required")]
        [Display(Name="Headline")]
        public string Headline { get; set; }

        [Required(ErrorMessage = "Total Experience Required")]
        [Display(Name = "Total Experience")]
        public int TotalExperience { get; set; }

        [Required(ErrorMessage = "Mobile Required")]
        [Display(Name = "Mobile")]
        public int Mobile { get; set; }

        [Display(Name = "Landline")]
        public int Landline { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [Display(Name = "Email")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "DOB Required")]
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Gender Required")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Upload File")]
        public string FilePath { get; set; }  

    }
}