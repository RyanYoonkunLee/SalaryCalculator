using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalaryCal.Data.Dtos
{
    public class SalaryCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public float Income { get; set; }
        [Required]
        public int KiwiSaver { get; set; }
        [Required]
        public bool StudentLoan { get; set; }
    }
}
