using AutoMapper;
using SalaryCal.Data.Dtos;
using SalaryCal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCal.Data.Profiles
{
    public class SalaryProfiles: Profile
    {
        public SalaryProfiles()
        {
            CreateMap<Salary, SalaryReadDto>();
            CreateMap<SalaryCreateDto, Salary>();
        }
    }
}
