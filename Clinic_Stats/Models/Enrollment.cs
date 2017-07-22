using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinic_Stats.Models
{
    public enum Visit {
        One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int UnitID { get; set; }
        public int PatientID { get; set; }
        public int StaffID { get; set; }
        public Visit? Visit { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Staff Staff { get; set; }


    }
}