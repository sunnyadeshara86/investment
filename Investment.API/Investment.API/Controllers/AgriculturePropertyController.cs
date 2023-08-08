using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgriculturePropertyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AgriculturePropertyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgriCultureProperty>>> GetAgricultureProperties()
        {
            var agricultureProperties = await _unitOfWork.AgriCulturePropertyRepository.Get();

            return Ok(agricultureProperties);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AgriCultureProperty>> GetAgricultureProperty(int id)
        {
            var agricultureProperty = await _unitOfWork.AgriCulturePropertyRepository.GetById(id);

            return Ok(agricultureProperty);
        }
    }
}
