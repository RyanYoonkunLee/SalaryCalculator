using SalaryCal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCal.Data.Data
{
    public class MockSalary : ISalaryCal
    {
        public void CreateSalary(Salary sal)
        {
            throw new NotImplementedException();
        }

        public void DeleteSalary(Salary sal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Salary> GetAllSalaries()
        {
            var salaries = new List<Salary>
            {
                new Salary(Guid.NewGuid(), "Ryan", 50000, 5, true),
                new Salary(Guid.NewGuid(), "Cindy", 30000, 3, false),
                new Salary(Guid.NewGuid(), "John", 80000, 4, true)
            };

            return salaries;
        }

        public Salary GetSalaryById(Guid id)
        {
            Salary temp = new Salary();
            temp.Id = Guid.NewGuid();
            temp.Name = "Yoonkun";
            temp.KiwiSaver = 5;
            temp.Income = 50000;
            temp.StudentLoan = true;
            return temp;
        }

        public bool SaveChagnges()
        {
            throw new NotImplementedException();
        }

        public void UpdateSalary(Salary sal)
        {
            throw new NotImplementedException();
        }
    }
}
