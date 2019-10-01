using CleanArch.Domain.Models;
using ClearArch.Infra.Data.Context;
using ClearArch.Infra.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearArch.Infra.Data.Repository
{
    public class UnitOfWork:IUniteOfWork
    {
        private SchoolsDBContext _context;
        public IUnitWorkRepository Repository { get; }

        public UnitOfWork(SchoolsDBContext context
        )
        {
            _context = context;
            Repository = new UnitOfWorkRepository(_context);
        }



        #region Detect Changes
        public void DetectChanges()
        {
            _context.ChangeTracker.DetectChanges();
        }
        #endregion

        #region Save Changes
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Transactions
        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _context.Database.RollbackTransaction();
        }
        #endregion


    }
}
