using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class SchoolViewModel
    {
        public IEnumerable<School> Schools { get; set; }
    }
}
