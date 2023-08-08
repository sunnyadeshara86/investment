using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CashController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cash>>> GetCash()
        {
            var cash = await _unitOfWork.CashRepository.Get();

            return Ok(cash);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cash>> GetCash(int id)
        {
            var cash = await _unitOfWork.CashRepository.GetById(id);

            return Ok(cash);
        }
    }
}
