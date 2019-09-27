using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ISchoolService
    {
        void AddSchool(School school);
        IEnumerable<School> GetAllSchools();
    }
}
