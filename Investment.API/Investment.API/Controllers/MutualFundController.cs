using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MutualFundController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MutualFundController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MutualFund>>> GetMutualFunds()
        {
            var mutualFunds = await _unitOfWork.MutualFundRepository.Get();

            return Ok(mutualFunds);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MutualFund>> GetMutualFund(int id)
        {
            var mutualFund = await _unitOfWork.MutualFundRepository.GetById(id);

            return Ok(mutualFund);
        }
    }
}
