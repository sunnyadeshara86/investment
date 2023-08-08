using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherPropertyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OtherPropertyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OtherProperty>>> GetOtherProperties()
        {
            var otherProperties = await _unitOfWork.OtherPropertyRepository.Get();

            return Ok(otherProperties);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OtherProperty>> GetOtherPropertie(int id)
        {
            var otherProperty = await _unitOfWork.OtherPropertyRepository.GetById(id);

            return Ok(otherProperty);
        }
    }
}
