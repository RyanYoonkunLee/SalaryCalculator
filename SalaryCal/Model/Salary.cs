using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalaryCal.Model
{
    public class Salary
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Income { get; set; }
        [Required]
        public int KiwiSaver { get; set; }
        [Required]
        public bool StudentLoan { get; set; }

        public Salary()
        {

        }
        public Salary(Guid id, string name, float income, int kiwisaver, bool studentloan)
        {
            this.Id = id;
            this.Name = name;
            this.Income = income;
            this.KiwiSaver = kiwisaver;
            this.StudentLoan = studentloan;
        }
    }
}
