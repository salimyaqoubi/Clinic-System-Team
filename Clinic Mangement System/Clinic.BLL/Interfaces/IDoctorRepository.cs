﻿using Clinic.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.BLL.Interfaces
{
    public interface IDoctorRepository : IDalGenericRepository<Doctor>
    {
        List<Doctor> GetDoctorsBySpecialization(int id);
    }
}
