using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using ClearArch.Infra.Data.Repository;
using ClearArch.Infra.Data.UnitOfWork;
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
            try
            {
                _unitOfWork.BeginTransaction();
                _unitOfWork.Repository.SchoolRepository.Create(school);
                _unitOfWork.SaveChanges();
                _unitOfWork.CommitTransaction();
            }
            catch (Exception excepcion)
            {
                _unitOfWork.RollbackTransaction();
                throw excepcion;
            }
           
        }

        public IEnumerable<School> GetAllSchools()
        {
            try
            {
                return _unitOfWork.Repository.SchoolRepository.GetAll();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void DeleteSchool(int id)
        {
            try
            {
                _unitOfWork.Repository.SchoolRepository.Delete(id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public School GetDataSchoolById(int id)
        {
            try
            {
                return _unitOfWork.Repository.SchoolRepository.Get(id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void UpdateSchool(School school)
        {
            try
            {
                School schoolUpdate = _unitOfWork.Repository.SchoolRepository.Get(school.Id);
                schoolUpdate.Name = school.Name;
                schoolUpdate.Description = school.Description;
                    _unitOfWork.Repository.SchoolRepository.Update(schoolUpdate);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void CreateSchool(School school)
        {
            try
            {
                school.CreationDate = DateTime.Now;
                school.Active = true;
                school.ImageUrl = "~";
                _unitOfWork.Repository.SchoolRepository.Create(school);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
