using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using ClearArch.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class SchoolService : ISchoolService
    {

        private IUniteOfWork _unitOfWork;
        public SchoolService(IUniteOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddSchool(School school)
        {

            _unitOfWork.SchoolRepository.Create(school);

            
        }

        public IEnumerable<School> GetAllSchools()
        {
            try
            {
                return _unitOfWork.SchoolRepository.GetAll();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
