using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Investment.Domain.Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FixedDepositController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FixedDepositController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FixedDeposit>>> GetFixedDeposits()
        {
            var fixedDeposits = await _unitOfWork.FixedDepositRepository.Get();

            return Ok(fixedDeposits);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FixedDeposit>> GetFixedDeposit(int id)
        {
            var fixedDeposit = await _unitOfWork.FixedDepositRepository.GetById(id);

            return Ok(fixedDeposit);
        }
    }
}
