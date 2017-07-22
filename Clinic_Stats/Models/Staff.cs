using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Clinic_Stats.Models
{
    public class Staff
    {
        
        public int StaffID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Profession { get; set; }
        public string Shift { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}