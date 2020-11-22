using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Data
{
    public class JobInfo
    {
        [Key]
        public int Id {get; set; }
        
        [Required]
        public string Department { get; set; }
        public int EmployeeCount { get; set; }

        [ForeignKey("EmployeeId")]
        public Employees Employee { get; set; }
        public string EmployeeId { get; set; }
        public int JobInvolvement { get; set; }
        public int JobLevel { get; set; }
        public string JobRole { get; set; }
        public int JobSatisfaction { get; set; }
        public int PerformanceRating { get; set; }
        public int RelationshipSatisfaction { get; set; }
        public int StandardHours { get; set; }
        public int StockOptionLevel { get; set; }
        public int TotalWorkingYears { get; set; }
        public int TrainingTimesLastYear { get; set; }
        public int WorkLifeBalance { get; set; }
        public int YearsAtCompany { get; set; }
        public int YearsInCurrentRole { get; set; }
        public int YearsSinceLastPromotion { get; set; }
        public int YearsWithCurrManager { get; set; }
    }
}
