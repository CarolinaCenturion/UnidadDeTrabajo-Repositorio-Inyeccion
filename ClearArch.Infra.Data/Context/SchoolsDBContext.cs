using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Infra.Data.Context
{
    public class SchoolsDBContext: DbContext
    {
        public SchoolsDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<School> Schools { get; set; }
    }
}
