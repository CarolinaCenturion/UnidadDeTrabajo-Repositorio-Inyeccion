
using CleanArch.Domain.Models;
using ClearArch.Infra.Data.Context;
using ClearArch.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Infra.Data.Repository
{
    public interface ISchoolRepository: IGenericRepository<School>
    {
        void AddSchool(School school);
        IEnumerable<School> GetSchools();
    }
    public class SchoolRepository : GenericRepository<School>, ISchoolRepository
    {
        public readonly SchoolsDBContext _context;
        public SchoolRepository(SchoolsDBContext ctx ):base(ctx)
        {
          
            _context = ctx;
        }

        public void AddSchool(School school)
        {
            _context.Schools.Add(school);
            
        }

        public IEnumerable<School> GetSchools()
        {
            return _context.Schools;

        }


    }
}
