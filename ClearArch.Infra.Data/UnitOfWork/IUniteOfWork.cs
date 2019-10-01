using CleanArch.Domain.Models;
using ClearArch.Infra.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClearArch.Infra.Data.Repository
{
    public interface IUniteOfWork
    {

        void DetectChanges();
        void SaveChanges();
        Task SaveChangesAsync();
        IDbContextTransaction BeginTransaction();
        Task<IDbContextTransaction> BeginTransactionAsync();
        void CommitTransaction();
        void RollbackTransaction();

        IUnitWorkRepository Repository { get; }
    }
}
