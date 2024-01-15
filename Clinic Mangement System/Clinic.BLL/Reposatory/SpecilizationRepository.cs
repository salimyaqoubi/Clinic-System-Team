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
    public class SpecilizationRepository : EfGenericRepository<Spatialization>, ISpecalizationRepository
    {
        public SpecilizationRepository(ApplicationDbContext contexte) : base(contexte)
        {
        }
    }
}
