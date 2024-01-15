using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL.Model
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public long PhoneNo { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }
    }
}
