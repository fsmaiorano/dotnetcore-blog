using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly BlogContext _context;

        public Repository(BlogContext context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Store(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }


        //public void Save(T entity)
        //{
        //    _context.Set<T>().Add(entity);
        //    _context.SaveChanges();
        //}
    }
}
