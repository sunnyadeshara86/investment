using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JewelleryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public JewelleryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jewellery>>> GetJewelleries()
        {
            var jewelleries = await _unitOfWork.JewelleryRepository.Get();

            return Ok(jewelleries);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Jewellery>> GetJewellery(int id)
        {
            var jewellery = await _unitOfWork.JewelleryRepository.GetById(id);

            return Ok(jewellery);
        }
    }
}
