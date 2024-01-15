using Clinic.BLL.Reposatory;
using Clinic.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.BLL.Interfaces
{
    public interface IAppointmentRepository : IDalGenericRepository<Appointment>
    {
    }
}
