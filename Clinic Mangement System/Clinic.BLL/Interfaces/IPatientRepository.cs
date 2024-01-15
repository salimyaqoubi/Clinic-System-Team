using Clinic.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.BLL.Interfaces
{
    public interface IPatientRepository : IDalGenericRepository<Patient>
    {
        string GetpatientName(int id);

        List<Appointment> GetAllAppointment(int id);
    }
}
