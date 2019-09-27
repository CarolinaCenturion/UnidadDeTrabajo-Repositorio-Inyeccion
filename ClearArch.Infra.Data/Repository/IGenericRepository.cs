using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Infra.Data.Repository
{
    public interface IGenericRepository<T> where T:class
    {

        T Get(int id);
        IEnumerable<T> GetAll();
        void Create(T newDataObject);
        void Delete(int id);
        void Update(T changeDataObject);
    }
}
