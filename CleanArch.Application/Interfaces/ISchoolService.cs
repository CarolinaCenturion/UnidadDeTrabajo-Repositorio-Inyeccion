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
        void DeleteSchool(int id);
        School GetDataSchoolById(int id);

        void UpdateSchool(School school);
        void CreateSchool(School school);
    }
}
