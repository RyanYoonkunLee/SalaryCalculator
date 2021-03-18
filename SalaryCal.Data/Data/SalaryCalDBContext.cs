using Microsoft.EntityFrameworkCore;
using SalaryCal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCal.Data.Data
{
    public class SalaryCalDBContext : DbContext
    {
        public SalaryCalDBContext(DbContextOptions<SalaryCalDBContext> opt) : base(opt)
        {

        }

        public DbSet<Salary> Salaries { get; set; }
    }
}
