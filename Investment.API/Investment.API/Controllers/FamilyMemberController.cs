using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Investment.Domain.Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyMemberController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FamilyMemberController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FamilyMember>>> GetFamilyMembers()
        {
            var familyMembers = await _unitOfWork.FamilyMemberRepository.Get();

            return Ok(familyMembers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FamilyMember>> GetFamilyMember(int id)
        {
            var familyMember = await _unitOfWork.FamilyMemberRepository.GetById(id);

            return Ok(familyMember);
        }
    }
}
