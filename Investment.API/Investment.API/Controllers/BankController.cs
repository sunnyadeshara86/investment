using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BankController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bank>>> GetBanks()
        {
            var banks = await _unitOfWork.BankRepository.Get();

            return Ok(banks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bank>> GetBank(int id)
        {
            var bank = await _unitOfWork.BankRepository.GetById(id);

            return Ok(bank);
        }
    }
}
