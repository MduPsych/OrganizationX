using OrganisationX.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Models
{
    public class SalaryVM
    { 
        public int Id { get; set; }
        [Required]
        public int DailyRate { get; set; }
        
        public Employees Employee { get; set; }
        public string EmployeeId { get; set; }
        public int HourlyRate { get; set; }
        public int MonthlyIncome { get; set; }
        public int MonthlyRate { get; set; }
        public string OverTime { get; set; }
        public int PercentSalaryHike { get; set; }
    }
}
