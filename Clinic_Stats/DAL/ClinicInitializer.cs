using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Clinic_Stats.Models;

namespace Clinic_Stats.DAL
{
    public class ClinicInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ClinicContext>
    {
        protected override void Seed(ClinicContext context)
        {
            

            var patients = new List<Patient>
            {
                new Patient{FirstMidName="Ali", LastName="Hamza", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Patient{FirstMidName="Abrahim",LastName="Faraz",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Patient{FirstMidName="Hira",LastName="Faheem",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Patient{FirstMidName="Saleem",LastName="Ali",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Patient{FirstMidName="Asim",LastName="Khan",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Patient{FirstMidName="Irfan",LastName="Najeeb",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Patient{FirstMidName="Maqbool",LastName="Ali",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Patient{FirstMidName="Majeed",LastName="Khan",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Patient{FirstMidName="Rukhsar",LastName="Fatima",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            patients.ForEach(s => context.Patients.Add(s));
            context.SaveChanges();

            var units = new List<Unit>
            {
            new Unit{UnitID=001, Title="Cardiology", Room="403"},
            new Unit{UnitID=002, Title="Optics", Room="402" },
            new Unit{UnitID=003, Title="Emergency", Room="405"},
            new Unit{UnitID=004, Title="General Physician", Room="401"},
            new Unit{UnitID=005, Title="ENT", Room="402"}
            
            };
            units.ForEach(s => context.Units.Add(s));
            context.SaveChanges();

            var staffs = new List<Staff>
            {
                new Staff{StaffID=1, FirstMidName="Akram", LastName="Haseeb", Profession="Doctor", Shift="First", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Staff{StaffID=2, FirstMidName="Mehmood", LastName="Shabnam", Profession="Specilist", Shift="Second", EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Staff{StaffID=3, FirstMidName="Maliha", LastName="Ali", Profession="Nurse", Shift="First", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Staff{StaffID=3, FirstMidName="Saleem", LastName="Mamon", Profession="Nurse", Shift="First", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Staff{StaffID=3, FirstMidName="Raheel", LastName="Waseem", Profession="Specilist", Shift="First", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Staff{StaffID=3, FirstMidName="Zuhaib", LastName="Ali", Profession="General Physician", Shift="First", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Staff{StaffID=3, FirstMidName="Maryam", LastName="Habeeb", Profession="Doctor", Shift="First", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Staff{StaffID=3, FirstMidName="Maliha", LastName="Khan", Profession="Doctor", Shift="First", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Staff{StaffID=3, FirstMidName="Aysha", LastName="Anvar", Profession="Doctor", Shift="First", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Staff{StaffID=3, FirstMidName="Hassan", LastName="Mahmood", Profession="Doctor", Shift="First", EnrollmentDate=DateTime.Parse("2005-09-01")}
            
            };
            staffs.ForEach(s => context.Staffs.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{PatientID=1, UnitID=001,  StaffID=1 ,Visit=Visit.One},
            new Enrollment{PatientID=2, UnitID=002,  StaffID=1, Visit=Visit.Two},
            new Enrollment{PatientID=3, UnitID=003,  StaffID=2, Visit=Visit.Three},
            new Enrollment{PatientID=1, UnitID=004,  Visit=Visit.Two},
            new Enrollment{PatientID=2, UnitID=001,  StaffID=3, Visit=Visit.One},
            new Enrollment{PatientID=3, UnitID=001,  StaffID=1, Visit=Visit.Four},
            new Enrollment{PatientID=1, UnitID=002,  Visit=Visit.One},
            new Enrollment{PatientID=2, UnitID=003,  Visit=Visit.One}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

           

        }
    }

}

        
    
