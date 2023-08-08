using Investment.Data;
using Investment.Domain.Entities.Core;
using Microsoft.AspNetCore.Mvc;
using Investment.Application;
using Investment.Application.UnitOfWork;
using Investment.Application.UnitOfWork.Interfaces;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _unitOfWork.AppUserRepository.Get();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser(int id)
        {
            var user = await _unitOfWork.AppUserRepository.GetById(id);

            return Ok(user);
        }
    }
}
