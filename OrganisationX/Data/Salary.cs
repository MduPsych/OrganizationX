using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Data
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        public int DailyRate { get; set; }
        [ForeignKey("EmployeeId")]
        public Employees Employee { get; set; }
        public string EmployeeId { get; set; }
        public int HourlyRate { get; set; }
        public int MonthlyIncome { get; set; }
        public int MonthlyRate { get; set; }
        public string OverTime { get; set; }
        public int PercentSalaryHike { get; set; }
    }
}
