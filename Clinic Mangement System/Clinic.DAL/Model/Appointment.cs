using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL.Model
{

    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Status { get; set; }

        //Foreign Key Patient Entity
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        public Patient? Patient { get; set; }

        //Foriegn Key Doctor Entity
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }


    }
}
