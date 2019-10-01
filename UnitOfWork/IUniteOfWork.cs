using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClearArch.Infra.Data.Repository
{
    public interface IUniteOfWork
    {

        IGenericRepository<School> SchoolRepository { get; }
     
        Task<bool> Save();
        Task<int> Commit();
        void Rollback();
    }
}
