using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCal.Data.Dtos
{
    public class SalaryReadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Income { get; set; }
        public int KiwiSaver { get; set; }   
    }
}
