using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Store(T entity);
        //void Save(T entity);
    }
}
