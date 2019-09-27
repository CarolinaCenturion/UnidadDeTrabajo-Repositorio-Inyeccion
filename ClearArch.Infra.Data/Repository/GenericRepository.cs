using ClearArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Infra.Data.Repository
{
    public class GenericRepository<T>:IGenericRepository<T> where T:class
    {
        protected SchoolsDBContext _ctx;
        public GenericRepository(SchoolsDBContext ctx) => _ctx = ctx;

        //Methods

        #region Querys

        public virtual T Get(int id)
        {
            try
            {
                return _ctx.Set<T>().Find(id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                return _ctx.Set<T>();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        #endregion

        #region Actions
        public virtual void Create(T newDataObject)
        {
            try
            {
                _ctx.Add<T>(newDataObject);
                _ctx.SaveChanges();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

       

        public virtual void Delete(int id)
        {
            try
            {
                _ctx.Remove<T>(Get(id));
                _ctx.SaveChanges();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public virtual void Update(T changeDataObject)
        {
            try
            {
                _ctx.Update<T>(changeDataObject);
                _ctx.SaveChanges();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion


    }
}
