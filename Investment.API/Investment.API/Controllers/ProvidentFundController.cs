using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidentFundController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProvidentFundController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProvidentFund>>> GetProvidentFunds()
        {
            var providentFunds = await _unitOfWork.ProvidentFundRepository.Get();

            return Ok(providentFunds);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProvidentFund>> GetProvidentFund(int id)
        {
            var providentFund = await _unitOfWork.OtherPropertyRepository.GetById(id);

            return Ok(providentFund);
        }
    }
}
