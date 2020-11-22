using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Models
{
    public class EmployeesVM
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MaritialStatus { get; set; }
        public string Over18 { get; set; }
        [Display(Name = "Distance From Home")]
        public int DistanceFromHome { get; set; }
        public string Attrition { get; set; }
        [Display(Name = "Number of Companies Worked For")]
        public int NumCompaniesWorked { get; set; }
        [Display(Name = "Environment Satisfaction")]
        public int EnvironmentSatisfaction { get; set; }

        [Display(Name = "Business Travel")]
        public string BusinessTravel { get; set; }

        public IEnumerable<SelectListItem> Education { get; set; }
        public IEnumerable<SelectListItem> JobInfo { get; set; }
        public IEnumerable<SelectListItem> Salary { get; set; }
    }   

 
}
