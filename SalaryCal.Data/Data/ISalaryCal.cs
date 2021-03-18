using SalaryCal.Model;
using System;
using System.Collections.Generic;

namespace SalaryCal.Data.Data
{
    public interface ISalaryCal
    {
        bool SaveChagnges();
        IEnumerable<Salary> GetAllSalaries();
        Salary GetSalaryById(Guid id);
        void CreateSalary(Salary sal);
        void UpdateSalary(Salary sal);
        void DeleteSalary(Salary sal);
    }
}
