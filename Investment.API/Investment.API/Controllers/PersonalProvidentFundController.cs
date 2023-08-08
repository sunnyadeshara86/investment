using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalProvidentFundController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonalProvidentFundController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonalProvidentFund>>> GetPersonalProvidentFunds()
        {
            var personalProvidentFunds = await _unitOfWork.PersonalProvidentFundRepository.Get();

            return Ok(personalProvidentFunds);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalProvidentFund>> GetPersonalProvidentFund(int id)
        {
            var personalProvidentFund = await _unitOfWork.PersonalProvidentFundRepository.GetById(id);

            return Ok(personalProvidentFund);
        }
    }
}
