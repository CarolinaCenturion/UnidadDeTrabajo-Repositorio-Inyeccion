using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Infra.Data.Repository
{
    public interface IUniteOfWork
    {

        IGenericRepository<School> SchoolRepository { get; }
        void Save();
    }
}
