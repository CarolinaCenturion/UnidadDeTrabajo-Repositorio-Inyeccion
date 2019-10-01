using ClearArch.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Infra.Data.UnitOfWork
{
    public interface IUnitWorkRepository
    {
        ISchoolRepository SchoolRepository { get; }
    }
}
