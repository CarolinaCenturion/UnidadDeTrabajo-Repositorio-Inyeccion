using ClearArch.Infra.Data.Context;
using ClearArch.Infra.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Infra.Data.Repository
{
    public class UnitOfWorkRepository: IUnitWorkRepository
    {
        public ISchoolRepository SchoolRepository { get; }

        public UnitOfWorkRepository(SchoolsDBContext context)
        {
            SchoolRepository = new SchoolRepository(context);
        }
    }
}
