using CleanArch.Domain.Models;
using ClearArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Infra.Data.Repository
{
    public class UnitOfWork:IUniteOfWork
    {
        private SchoolsDBContext _context;
        private IGenericRepository<School> _schoolRepository;

        public UnitOfWork(SchoolsDBContext context)
        {
            _context = context;
        }

        public IGenericRepository<School> SchoolRepository
        {
            get
            {
                return _schoolRepository = _schoolRepository ?? new GenericRepository<School>(_context);
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
