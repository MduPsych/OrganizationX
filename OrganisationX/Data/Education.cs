using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Data
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("EmployeeId")]
        public Employees Employee { get; set; }
        public string EmployeeId { get; set; }
        public int EducationLevel { get; set; }
        
        public string EducationField { get; set; }
      
    }
}
