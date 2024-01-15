using Clinic.BLL.Interfaces;
using Clinic.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.BLL.Reposatory
{
    public class EfGenericRepository<T> : IDalGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public EfGenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Create(T item)
        {
            _context.Set<T>().Add(item);
            return _context.SaveChanges();
        }

        public int Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);

        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public int Update(T item)
        {
            _context.Set<T>().Update(item);
            return _context.SaveChanges();
        }

    }
}
