using Clinic.BLL.Interfaces;
using Clinic.DAL.Context;
using Clinic.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.BLL.Reposatory
{
    public class DoctorRepository : EfGenericRepository<Doctor>, IDoctorRepository
    {
        private readonly ApplicationDbContext _context;
        public DoctorRepository(ApplicationDbContext contexte) : base(contexte)
        {
            _context = contexte;
        }

        public List<Doctor> GetDoctorsBySpecialization(int id)
        {
            var doctors = _context.Doctors
        .Where(d => d.Spatialization.SpatializationID == id)
        .ToList();
            return doctors;
        }
    }
}
