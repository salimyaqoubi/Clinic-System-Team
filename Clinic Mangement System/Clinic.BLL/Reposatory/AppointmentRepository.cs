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
    public class AppointmentRepository : EfGenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
