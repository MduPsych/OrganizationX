using OrganisationX.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Models
{
    public class EducationVM
    {
        public int Id { get; set; }


        public Employees Employee { get; set; }
        public string EmployeeId { get; set; }
        [Required]
        public int EducationLevel { get; set; }

        public string EducationField { get; set; }
    }
}
