using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clinic_Stats.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Clinic_Stats.DAL
{
    public class ClinicContext : DbContext
    {
        public ClinicContext() : base("ClinicContext")
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder )
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}