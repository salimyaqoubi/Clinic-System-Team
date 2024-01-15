﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL.Model
{
    public class Spatialization
    {
        [Key]
        public int SpatializationID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
