using SalaryCal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCal.Data.Data
{
    public class SalaryDataAccess : ISalaryCal
    {
        private readonly SalaryCalDBContext _context;
        public SalaryDataAccess(SalaryCalDBContext context)
        {
            _context = context;
        }

        public void CreateSalary(Salary sal)
        {
            if(sal == null)
            {
                throw new ArgumentNullException(nameof(sal));
            }

            _context.Salaries.Add(sal);
        }

        public void DeleteSalary(Salary sal)
        {
            if(sal == null)
            {
                throw new ArgumentException(nameof(sal));
            }
            _context.Salaries.Remove(sal);
        }

        public IEnumerable<Salary> GetAllSalaries()
        {
            return _context.Salaries.ToList();
        }

        public Salary GetSalaryById(Guid id)
        {
            return _context.Salaries.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChagnges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateSalary(Salary sal)
        {
            
        }
    }
}
