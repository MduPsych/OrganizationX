using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganisationX.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employees> Employeee { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<JobInfo> JobInfos { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}
