using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostOfficeSavingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostOfficeSavingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostOfficeSaving>>> GetPostOfficeSavings()
        {
            var postOfficeSavings = await _unitOfWork.PostOfficeSavingFundRepository.Get();

            return Ok(postOfficeSavings);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostOfficeSaving>> GetPostOfficeSaving(int id)
        {
            var postOfficeSaving = await _unitOfWork.PostOfficeSavingFundRepository.GetById(id);

            return Ok(postOfficeSaving);
        }
    }
}
