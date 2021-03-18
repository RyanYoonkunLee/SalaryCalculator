using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalaryCal.Data.Data;
using SalaryCal.Data.Dtos;
using SalaryCal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCal.Web.Controllers
{
    //api/salary
    [Route("api/salary")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryCal _salaryCal;
        private readonly IMapper _mapper;

        public SalaryController(ISalaryCal salaryCal, IMapper mapper)
        {
            _salaryCal = salaryCal;
            _mapper = mapper;
        }

        //GET api/salary
        [HttpGet]
        public ActionResult<IEnumerable<SalaryReadDto>> GetAllSalaries()
        {
            var salaryItems = _salaryCal.GetAllSalaries();

            return Ok(_mapper.Map<IEnumerable<SalaryReadDto>>(salaryItems));
        }

        //GET api/salary/{id}
        [HttpGet("{id}", Name = "GetSalaryById")]
        public ActionResult<SalaryReadDto> GetSalaryById(Guid id)
        {
            var salaryItem = _salaryCal.GetSalaryById(id);
            if (salaryItem != null)
            {
                return Ok(_mapper.Map<SalaryReadDto>(salaryItem));
            }
            return NotFound();
        }

        //POST api/salary
        [HttpPost]
        public ActionResult<SalaryReadDto> CreateSalary(SalaryCreateDto salaryCreate)
        {
            var salaryModel = _mapper.Map<Salary>(salaryCreate);
            _salaryCal.CreateSalary(salaryModel);
            _salaryCal.SaveChagnges();

            var salaryReadDto = _mapper.Map<SalaryReadDto>(salaryModel);


            return CreatedAtRoute(nameof(GetSalaryById), new { Id = salaryReadDto.Id }, salaryReadDto);
            //return Ok(salaryReadDto);
        }

        //PUT api/salary/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateSalary(Guid id, SalaryCreateDto salaryUpdate)
        {
            var findSalary = _salaryCal.GetSalaryById(id);
            if (findSalary == null)
            {
                return NotFound();
            }

            _mapper.Map(salaryUpdate, findSalary);
            _salaryCal.UpdateSalary(findSalary);
            _salaryCal.SaveChagnges();

            return NoContent();
        }
        //DELETE api/salary/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteSalary(Guid id)
        {
            var findSalary = _salaryCal.GetSalaryById(id);
            if(findSalary == null)
            {
                return NotFound();
            }
            _salaryCal.DeleteSalary(findSalary);
            _salaryCal.SaveChagnges();

            return NoContent();

        }
    }
}
