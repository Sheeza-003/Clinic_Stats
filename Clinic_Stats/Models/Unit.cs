using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Clinic_Stats.Models
{
    public class Unit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitID { get; set; }
        public string Title { get; set; }
        public string Room { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}