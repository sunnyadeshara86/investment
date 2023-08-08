using Investment.Application.UnitOfWork.Interfaces;
using Investment.Domain.Entities.Assets;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalSavingCertificateController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public NationalSavingCertificateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NationalSavingCertificate>>> GetNationalSavingCertificates()
        {
            var nationalSavingCertificates = await _unitOfWork.NationalSavingCertificateRepository.Get();

            return Ok(nationalSavingCertificates);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NationalSavingCertificate>> GetNationalSavingCertificate(int id)
        {
            var nationalSavingCertificate = await _unitOfWork.NationalSavingCertificateRepository.GetById(id);

            return Ok(nationalSavingCertificate);
        }
    }
}
