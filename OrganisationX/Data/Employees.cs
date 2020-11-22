using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Data
{
    public class Employees : IdentityUser
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MaritialStatus { get; set; }
        public string Over18 { get; set; }
        public int DistanceFromHome { get; set; }
        public string Attrition { get; set; }
        public int NumCompaniesWorked { get; set; }

        public int EnvironmentSatisfaction { get; set; }
        public string BusinessTravel { get; set; }
    }
}
