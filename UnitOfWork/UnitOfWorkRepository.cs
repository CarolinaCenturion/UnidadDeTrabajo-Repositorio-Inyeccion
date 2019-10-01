using ClearArch.Infra.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using ClearArch.Domain

namespace ClearArch.Infra.Data.Repository
{
    public class UnitOfWorkRepository: IUnitOfWorkRepository
    {
        public ISchoolRepository schoolRepository { get; }
    }
}
