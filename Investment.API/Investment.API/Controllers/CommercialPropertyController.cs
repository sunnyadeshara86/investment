using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommercialPropertyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommercialPropertyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommercialProperty>>> GetCommercialProperty()
        {
            var commercialProperties = await _unitOfWork.CommercialPropertyRepository.Get();

            return Ok(commercialProperties);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CommercialProperty>> GetCommercialProperty(int id)
        {
            var commercialProperty = await _unitOfWork.CommercialPropertyRepository.GetById(id);

            return Ok(commercialProperty);
        }
    }
}
