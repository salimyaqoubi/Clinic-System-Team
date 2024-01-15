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
    public class PatientRepository : EfGenericRepository<Patient>, IPatientRepository
    {
        private readonly ApplicationDbContext _context;
        public PatientRepository(ApplicationDbContext contexte) : base(contexte)
        {
            _context = contexte;
        }

        public List<Appointment> GetAllAppointment(int id)
        {
            var appoints = _context.Appointments.Where(a => a.PatientID == id).ToList();
            return appoints;
        }

        public string GetpatientName(int id)
        {
            return _context.Patients.FirstOrDefault(n => n.PatientID == id).Name;
        }
    }
}
