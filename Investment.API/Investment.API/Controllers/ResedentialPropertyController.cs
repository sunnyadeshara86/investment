using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResedentialPropertyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResedentialPropertyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResedentialProperty>>> GetResedentialProperties()
        {
            var resedentialProperties = await _unitOfWork.ResedentialPropertyRepository.Get();

            return Ok(resedentialProperties);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResedentialProperty>> GetResedentialProperty(int id)
        {
            var resedentialProperty = await _unitOfWork.ResedentialPropertyRepository.GetById(id);

            return Ok(resedentialProperty);
        }
    }
}
